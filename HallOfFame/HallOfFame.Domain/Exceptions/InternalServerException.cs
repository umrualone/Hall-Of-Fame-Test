namespace HallOfFame.Domain.Exceptions
{
    public class InternalServerException : Exception
    {
        public InternalServerException(string file) : base(file) { }
    }
}