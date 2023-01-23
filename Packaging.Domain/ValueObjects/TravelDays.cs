namespace Packaging.Domain.ValueObjects
{
    public record TravelDays
    {
        public ushort Value { get; }

        public TravelDays(ushort value)
        {
            if (value is 0 or > 100)
            {
                throw new Exception(); // TODO: Custom Exception
            }

            Value = value;
        }

        public static implicit operator ushort(TravelDays days) => days.Value;

        public static implicit operator TravelDays(ushort days) => new(days);
    }
}