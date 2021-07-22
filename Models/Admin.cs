using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Business;

namespace IteratorPattern.Models {
  class Admin {
    internal Admin() {
      DepartmentOfArt memberOfArt = new DepartmentOfArt();
      DepartmentOfEngineering memberOfEng = new DepartmentOfEngineering();
    }
    void PrintMembers() {
      
    }
  }
}
