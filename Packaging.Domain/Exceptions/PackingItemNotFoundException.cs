using Packaging.Shared.Abstractions.Exceptions;

namespace Packaging.Domain.Exceptions
{
    public class PackingItemNotFoundException : PackItException
    {
        public string Item { get; }
        public PackingItemNotFoundException(string item) : base($"Packing item '{item}' was not found")
        {
            Item = item;
        }
    }
}