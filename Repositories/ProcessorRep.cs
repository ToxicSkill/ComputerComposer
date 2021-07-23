using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;

namespace ComputerComposerNsp.Repositories
{
    class ProcessorRep : Repository, IElements<Processor>
    {
        public List<string> GetStringList()
        {
            List<Processor> processors = new List<Processor>(DbContext.Processors.ToList());
            List<string> sprocessors = new List<string>();
            foreach (var processor in processors)
                sprocessors.Add(processor.Name);
            return new List<string>(sprocessors);
        }

        public List<Processor> GetLists()
        {
            return DbContext.Processors.ToList();
        }

        public float GetPriceByName(string name)
        {
            return DbContext.Processors.Single(c => c.Name == name).Price;
        }
    }
}
