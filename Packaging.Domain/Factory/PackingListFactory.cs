using Packaging.Domain.Constants;
using Packaging.Domain.Entities;
using Packaging.Domain.Policies;
using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Factory
{
    public class PackingListFactory : IPackingListFactory
    {
        private readonly IEnumerable<IPackingItemsPolicy> _policies;

        public PackingListFactory(IEnumerable<IPackingItemsPolicy> policies)
        {
            _policies = policies;
        }

        public PackingList Create(PackingListId id, PackingListName name, Localization localization)
        {
            return new(id, name, localization);
        }

        public PackingList CreateWithDefaultItem(PackingListId id,
                                                 PackingListName name,
                                                 TravelDays days,
                                                 Gender gender,
                                                 Temperature temperature,
                                                 Localization localization)
        {
            PolicyData data = new PolicyData(days, gender, temperature, localization);

            IEnumerable<IPackingItemsPolicy> applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            IEnumerable<PackingItem> items = applicablePolicies.SelectMany(p => p.GenerateItems(data));

            PackingList packingList = Create(id, name, localization);

            packingList.AddItems(items);

            return packingList;
        }
    }
}