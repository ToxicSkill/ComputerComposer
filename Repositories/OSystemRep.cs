using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;

namespace ComputerComposerNsp.Repositories
{
    class OSystemRep : Repository,IElements<OSystem>
    {
        public List<string> GetStringList()
        {
            List<OSystem> osystems = new List<OSystem>(DbContext.OSystems.ToList());
            List<string> sosystems = new List<string>();
            foreach (var system in osystems)
                sosystems.Add(system.Name);
            return new List<string>(sosystems);
        }

        public List<OSystem> GetLists()
        {
            return DbContext.OSystems.ToList();
        }

        public float GetPriceByName(string name)
        {
            return DbContext.OSystems.Single(c => c.Name == name).Price;
        }
    }
}
