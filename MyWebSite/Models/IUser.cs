namespace MyWebSite.Models
{
    public interface IUser
    {
        IEnumerable<User> Users { get; }
        void AddUser(User user);
    }
}
