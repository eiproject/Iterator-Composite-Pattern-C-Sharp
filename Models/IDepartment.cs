using IteratorPattern.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models {
  interface IDepartment {
    IIterator CreateIterator();
  }
}
