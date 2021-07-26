using System.Collections;
using IteratorPattern.Models;

namespace IteratorPattern.Business {
  interface IDepartment {
    object GetMembers();
    IIterator CreateIterator();
    IEnumerable CreateIterator(Component basecomponent);
  }
}
