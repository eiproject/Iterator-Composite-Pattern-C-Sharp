using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCompositePattern.Business {
  interface IIterator {
    bool HasNext();
    object Next();
  }
}
