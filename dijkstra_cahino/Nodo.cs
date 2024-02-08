using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra_cahino
{
     class Nodo:IComponent
    {
        public string Name { get; set; }
        public List<IComponent> Children { get; } = new List<IComponent>();
        public Nodo(string name) 
        {
            Name = name;
        }
        public void Add(IComponent component)
        {
            Children.Add(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var child in Children)
            {
                child.Display(depth + 2);
            }
        }
    }
}
