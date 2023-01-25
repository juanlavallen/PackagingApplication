using Packaging.Domain.Entities;
using Packaging.Domain.ValueObjects;
using Packaging.Shared.Abstractions.Domain;

namespace Packaging.Domain.Events
{
    public record PackingItemRemoved(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
}