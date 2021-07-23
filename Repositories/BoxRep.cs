using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;

namespace ComputerComposerNsp.Repositories
{
    /// <summary>
    /// Box repository class
    /// </summary>
    class BoxRep : Repository, IElements<Box>
    {
        /// <summary>
        /// Method for getting string list for combo boxes
        /// </summary>
        /// <returns></returns>
        public List<string> GetStringList()
        {
            List<Box> boxes = new List<Box>(DbContext.Boxes.ToList());
            List<string> sboxes = new List<string>();
            foreach (var box in boxes)
                sboxes.Add(box.Name);
            return new List<string>(sboxes);
        }
        /// <summary>
        /// Method for getting list of item for data grid view
        /// </summary>
        /// <returns></returns>
        public List<Box> GetLists()
        {
            return DbContext.Boxes.ToList();
        }

        /// <summary>
        /// Method for getting price of item by given name of it
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public float GetPriceByName(string name)
        {
            return DbContext.Boxes.Single(c => c.Name == name).Price;
        }
    }
}
