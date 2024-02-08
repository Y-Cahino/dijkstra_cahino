using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra_cahino
{
     class Composite
    {
        private List<IComponent> children = new List<IComponent>();

        public string Name { get; }

        public Composite(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            children.Add(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var child in children)
            {
                child.Display(depth + 2);
            }
        }
    }
}
