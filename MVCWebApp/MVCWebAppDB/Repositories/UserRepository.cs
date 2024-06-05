using MVCWebAppDB.Models;

namespace MVCWebAppDB.Repositories
{
    public class UserRepository
    {
            private readonly List<User> _users = new List<User>();

            public User GetUserByUsername(string username)
            {
                return _users.FirstOrDefault(u => u.Username == username);
            }

            public void AddUser(User user)
            {
                _users.Add(user);
            }
        }

    }

