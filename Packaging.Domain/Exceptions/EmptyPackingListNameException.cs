using Packaging.Shared.Abstractions.Exceptions;

namespace Packaging.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackItException
    {
        public EmptyPackingListNameException() : base("Packing List name cannot be empty")
        {
        }
    }
}