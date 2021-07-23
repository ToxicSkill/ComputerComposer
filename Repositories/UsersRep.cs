using System.Linq;
using ComputerComposerNsp.Repositories.Interfaces;
using ComputerComposerNsp.Models.Entities;

namespace ComputerComposerNsp.Repositories
{
    /// <summary>
    /// Class for defining methods which are connected to Users table repository
    /// </summary>
    public class UsersRep : Repository, IUsersRep
    {
        /// <summary>
        /// Method for checking if logging in can be done with passed login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string login, string password)
        {
            //assigning found by login user to the new user
            User user = DbContext.Users.SingleOrDefault(c => c.Login == login);
            //checking if user exist
            if (user == null)
                return false;
            //checking id password is correct
            if (user.Password == password)
                return true;
            else
               return false;
        }

        /// <summary>
        /// Method for creating new user
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Register(string login, string password)
        {
            //creating new user with given password and login
            User user = new User()
            {
                Login = login,
                Password = password
            };

            //adding new user to database
            DbContext.Users.Add(user);

            //saving changes
            return DbContext.SaveChanges() > 0;
        }
    }
}
