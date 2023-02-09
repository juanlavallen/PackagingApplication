using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Policies.Temperature
{
    public class HighTemperaturePolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        {
            return new List<PackingItem>
            {
                new("Hat", 1),
                new("Sunglasses", 1),
                new("Cream with UV filter", 1),
            };
        }

        public bool IsApplicable(PolicyData data)
        {
            return data.Temperature > 250;
        }
    }
}