namespace HallOfFame.Domain.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string file) : base(file) { }
    }
}