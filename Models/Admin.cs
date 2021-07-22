using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCompositePattern.Models {
  class Admin {
    internal Admin() {
      DepartmentOfArt memberOfArt = new DepartmentOfArt();
      DepartmentOfEngineering memberOfArt = new DepartmentOfArt();
    }
    void PrintMembers() {

    }
  }
}
