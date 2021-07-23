using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;

namespace ComputerComposerNsp.Repositories
{
    class RamRep : Repository, IElements<Ram>
    {
        public List<string> GetStringList()
        {
            List<Ram> rams = new List<Ram>(DbContext.Rams.ToList());
            List<string> srams = new List<string>();
            foreach (var ram in rams)
                srams.Add(ram.Name);
            return new List<string>(srams);
        }

        public List<Ram> GetLists()
        {
            return DbContext.Rams.ToList();
        }

        public float GetPriceByName(string name)
        {
            return DbContext.Rams.Single(c => c.Name == name).Price;
        }
    }
}
