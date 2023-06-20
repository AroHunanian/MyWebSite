namespace MyWebSite.Models
{
    public class UserModel : IUser
    {
        private List<User> users = new List<User>();
        public  IEnumerable<User> Users => users;

        public void AddUser(User user)
        {
           users.Add(user);
        }
    }
}
