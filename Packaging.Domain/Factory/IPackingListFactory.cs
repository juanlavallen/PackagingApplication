using Packaging.Domain.Constants;
using Packaging.Domain.Entities;
using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Factory
{
    public interface IPackingListFactory
    {
        PackingList Create(PackingListId id, PackingListName name, Localization localization);

        PackingList CreateWithDefaultItem(PackingListId id,
                                          PackingListName name,
                                          TravelDays days,
                                          Gender gender,
                                          Temperature temperature,
                                          Localization localization);
    }
}