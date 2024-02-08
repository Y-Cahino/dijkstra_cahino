using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra_cahino
{
     public interface IComponent
    {
        string Name { get; }
        void Added(IComponent component);
        void Display(int depth);
    }
}
