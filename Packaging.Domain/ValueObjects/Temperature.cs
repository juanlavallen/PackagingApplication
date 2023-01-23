namespace Packaging.Domain.ValueObjects
{
    public record Temperature
    {
        public double Value { get; }

        public Temperature(double value)
        {
            if (value is < -100 or > 100)
            {
                throw new Exception(); // TODO: Custom Exception
            }

            Value = value;
        }

        public static implicit operator double(Temperature temperature) => temperature.Value;

        public static implicit operator Temperature(double temperature) => new(temperature);
    }
}