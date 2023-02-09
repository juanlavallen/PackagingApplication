using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Policies.Gender
{
    public sealed class FemaleGenderPolicy : IPackingItemsPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        {
            return new List<PackingItem> { new("Lipstick", 1), new("Powder", 1), new("Eyeliner", 1) };
        }

        public bool IsApplicable(PolicyData data)
        {
            return data.Gender is Constants.Gender.Female;
        }
    }
}