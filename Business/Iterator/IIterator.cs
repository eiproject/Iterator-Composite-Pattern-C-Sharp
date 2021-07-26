using IteratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Business {
  interface IIterator {
    bool HasNext();
    object Next();
    void Remove();
  }
}
