using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;

namespace ComputerComposerNsp.Repositories
{
    class PowerUnitRep : Repository, IElements<PowerUnit>
    {
        public List<string> GetStringList()
        {
            List<PowerUnit> powerUnits = new List<PowerUnit>(DbContext.PowerUnits.ToList());
            List<string> spowerUnits = new List<string>();
            foreach (var powerUnit in powerUnits)
                spowerUnits.Add(powerUnit.Name);
            return new List<string>(spowerUnits);
        }

        public List<PowerUnit> GetLists()
        {
            return DbContext.PowerUnits.ToList();
        }

        public float GetPriceByName(string name)
        {
            return DbContext.PowerUnits.Single(c => c.Name == name).Price;
        }
    }
}
