using System.Collections;
using IteratorPattern.Models;

namespace IteratorPattern.Business {
  interface IDepartment {
    object GetMembers();
    IEnumerable CreateIterator();
  }
}
