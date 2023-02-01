using Packaging.Shared.Abstractions.Exceptions;

namespace Packaging.Domain.Exceptions
{
    public class EmptyPackingListIdException : PackItException
    {
        public EmptyPackingListIdException() : base("Packing List Id be empty")
        {
        }
    }
}