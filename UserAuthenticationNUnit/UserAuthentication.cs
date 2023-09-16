using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthenticationNUnit
{
    public class UserAuthentication
    {
        private List<User> users = new List<User>();
        public void UserRegistration(string username, string password)
        {
            users.Add(new User { Username = username, Password = password });
        }
        public bool UserLogin(string username, string password)
        {
            return users.Exists(u => u.Username == username && u.Password == password);
        }
        public void PasswordReset(string username, string newPassword)
        {
            var user = users.Find(u => u.Username == username);
            if (user != null)
            {
                user.Password = newPassword;
            }
        }
    }
}
