using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Policies
{
    public record PolicyData(TravelDays Days,
                             Constants.Gender Gender,
                             ValueObjects.Temperature Temperature,
                             Localization Localization)
    {
    }
}