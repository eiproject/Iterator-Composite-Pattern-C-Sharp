using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models {
  abstract class Component {
    public abstract string Name { get; }
    public abstract int Age { get; }
    public abstract int Height { get; }
    public abstract int Weight { get; }

    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract void Print();
  }
}
