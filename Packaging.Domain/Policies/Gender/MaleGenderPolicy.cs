using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Policies.Gender
{
    public sealed class MaleGenderPolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        {
            return new List<PackingItem>
            {
                new("Laptop", 1),
                new("Beer", 10),
                new("Book", (uint) Math.Ceiling(data.Days/7m)),
            };
        }

        public bool IsApplicable(PolicyData data)
        {
            return data.Gender is Constants.Gender.Male;
        }
    }
}