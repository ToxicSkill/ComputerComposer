using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;

namespace ComputerComposerNsp.Repositories
{
    class GraphicRep : Repository,IElements<Graphic>
    {
        public List<string> GetStringList()
        {
            List<Graphic> graphics = new List<Graphic>(DbContext.Graphics.ToList());
            List<string> sgraphics = new List<string>();
            foreach (var graph in graphics)
                sgraphics.Add(graph.Name);
            return new List<string>(sgraphics);
        }

        public List<Graphic> GetLists()
        {
            return DbContext.Graphics.ToList();
        }

        public float GetPriceByName(string name)
        {
            return DbContext.Graphics.SingleOrDefault(c => c.Name == name).Price;
        }
    }
}
