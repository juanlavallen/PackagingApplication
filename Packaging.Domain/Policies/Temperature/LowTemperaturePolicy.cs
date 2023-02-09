using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Policies.Temperature
{
    public class LowTemperaturePolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        {
            return new List<PackingItem>
            {
                new("Scarf", 1),
                new("Gloves", 1),
                new("Hoodie", 1),
                new("Winter hat", 1),
                new("Warm jacket", 1),
            };
        }

        public bool IsApplicable(PolicyData data)
        {
            return data.Temperature < 100;
        }
    }
}