namespace NorthWind.Entities.ValueObject
{
    public class UserAction(string user, string description)
    {
        public DateTime CreateDateTime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;
    }
}
