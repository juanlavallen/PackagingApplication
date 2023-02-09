using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Policies.Universal
{
    public sealed class BasicPolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        {
            return new List<PackingItem>
            {
                new("Pants", Math.Min(data.Days, byte.MaxValue)),
                new("Socks", Math.Min(data.Days, byte.MaxValue)),
                new("T-Shirt", Math.Min(data.Days, byte.MaxValue)),
                new("Trousers", data.Days < 7 ? 1u : 2u),
                new("Shampoo", 1),
                new("Toothbrush", 1),
                new("Toothpaste", 1),
                new("Towel", 1),
                new("Bag pack", 1),
                new("Passport", 1),
                new("Phone Charger", 1)
            };
        }

        public bool IsApplicable(PolicyData data) => true;
    }
}