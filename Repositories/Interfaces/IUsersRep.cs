namespace ComputerComposerNsp.Repositories.Interfaces
{
    /// <summary>
    /// Interface for defining methods which are connected to users table repository
    /// </summary>
    public interface IUsersRep
    {
        /// <summary>
        /// Abstract method for logging from Users table - based on login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string login, string password);

        /// <summary>
        /// Abstract method for registering new user
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Register(string login, string password);
    }
}
