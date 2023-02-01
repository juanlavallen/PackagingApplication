using Packaging.Domain.Events;
using Packaging.Domain.ValueObjects;
using Packaging.Shared.Abstractions.Domain;

namespace Packaging.Domain.Entities
{
    public class PackingList : AggregateRoot<PackingList>
    {
        public PackingListId Id { get; private set; }

        private PackingListName _name;
        private Localization _localization;

        private readonly LinkedList<PackingItem> _items = new();

        private PackingList(
                PackingListId id,
                PackingListName name,
                Localization localization,
                LinkedList<PackingItem> items
        ) : this(id, name, localization)
        {
            _items = items;
        }

        private PackingList()
        {
        }

        internal PackingList(PackingListId id, PackingListName name, Localization localization)
        {
            Id = id;
            _name = name;
            _localization = localization;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = _items.Any(x => x.Name == item.Name);

            if (alreadyExists)
            {
                throw new Exception(); // TODO: CustomException
            }

            _items.AddLast(item);
            AddEvent(new PackingItemAdded(this, item));
        }

        public void AddItems(IEnumerable<PackingItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }

        public void PackItem(string name)
        {
            var item = GetItem(name);

            var packedItem = item with { IsPacked = true };

            _items.Find(item)!.Value = packedItem;

            AddEvent(new PackingItemPacked(this, item));
        }

        public void RemoveItem(string itemName)
        {
            var item = GetItem(itemName);
            _items.Remove(item);
            AddEvent(new PackingItemRemoved(this, item));
        }

        private PackingItem GetItem(string name)
        {
            var item = _items.SingleOrDefault(i => i.Name == name);

            if (item is null)
            {
                throw new Exception(); // TODO: CustomException
            }

            return item;
        }
    }
}