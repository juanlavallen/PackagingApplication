namespace Packaging.Domain.ValueObjects
{
    public record class Localization(string City, string Country)
    {
        public static Localization Create(string value)
        {
            var split = value.Split(',');

            return new Localization(split.First(), split.Last());
        }

        public override string ToString() => $"{City},{Country}";
    }
}