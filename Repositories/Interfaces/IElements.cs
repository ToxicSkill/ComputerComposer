using System.Collections.Generic;

namespace ComputerComposerNsp.Repositories.Interfaces
{
    /// <summary>
    /// Interface for defining methods for computer elements repositories
    /// </summary>
    public interface IElements<T>
    {
        /// <summary>
        /// Abstract method for getting list of elements for data grid view
        /// </summary>
        /// <param name="computerID"></param>
        List<T> GetLists();

        /// <summary>
        /// Abstract method for getting string list for combo boxes
        /// </summary>
        /// <param name="computerID"></param>
        List<string> GetStringList();

        /// <summary>
        /// Abstract method for getting price of item by given name of it
        /// </summary>
        /// <param name="computerID"></param>
        float GetPriceByName(string name);
    }

}
