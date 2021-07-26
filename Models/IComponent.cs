using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models {
  interface IComponent {
    void Add();
    void Remove();
    string Name { get; }
    int Age { get; }
    int Height { get; }
    int Weight { get; }
    void Print();
  }
}
