using Packaging.Shared.Abstractions.Exceptions;

namespace Packaging.Domain.Exceptions
{
    public class InvalidTravelDaysException : PackItException
    {
        public ushort Days { get; }
        public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days")
        {
            Days = days;
        }
    }
}