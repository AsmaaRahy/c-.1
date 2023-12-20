using System.Runtime.Serialization;

namespace Task3
{
    [Serializable]
    internal class DuplicateNumberException : Exception
    {
        private int num;

        public DuplicateNumberException()
        {
        }

        public DuplicateNumberException(int num)
        {
            this.num = num;
        }

        public DuplicateNumberException(string? message) : base(message)
        {
        }

        public DuplicateNumberException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}