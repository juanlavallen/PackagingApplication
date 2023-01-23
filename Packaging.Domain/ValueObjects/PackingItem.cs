namespace Packaging.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name { get; }
        public uint Quantity { get; }
        public bool IsPacked { get; init; }

        public PackingItem(string name, uint quantity, bool isPacked = false)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(); // TODO: Custom Exception
            }

            Name = name;
            Quantity = quantity;
            IsPacked = isPacked;
        }
    }
}