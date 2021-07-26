using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IteratorPattern.Models;

namespace IteratorPattern.Business {
  class Admin {
    Component _allComponent;
    internal Admin(Component components) {
      _allComponent = components;
    }
    internal void PrintMembers() {
      _allComponent.Print();
    }
  }
}
