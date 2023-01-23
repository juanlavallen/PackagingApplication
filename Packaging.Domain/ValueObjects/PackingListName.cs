namespace Packaging.Domain.ValueObjects
{
    public record PackingListName
    {
        public string Value { get; }

        public PackingListName(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(); // TODO: Custom Exception
            }

            Value = value;
        }

        public static implicit operator string(PackingListName name) => name.Value;

        public static implicit operator PackingListName(string name) => new(name);
    }
}