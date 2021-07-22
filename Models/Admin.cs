using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Business;

namespace IteratorPattern.Models {
  class Admin {
    private DepartmentOfArt _memberOfArt;
    private DepartmentOfEngineering _memberOfEng;

    internal Admin() {
      _memberOfArt = new DepartmentOfArt();
      _memberOfEng = new DepartmentOfEngineering();
    }
    internal void PrintMembers() {
      IIterator iteratorOfArt = _memberOfArt.GetIterator();
      IIterator iteratorOfEng = _memberOfEng.GetIterator();
      Console.WriteLine("Members from Department of Art");
      Console.WriteLine("Name\tAge\tHeight\tWeight");
      PrintMembers(iteratorOfArt);
      Console.WriteLine("\nMembers from Department of Engineering");
      Console.WriteLine("Name\tAge\tHeight\tWeight");
      PrintMembers(iteratorOfEng);
    }
    void PrintMembers(IIterator iterator) {
      while (iterator.HasNext()) {
        Student currentStudent = (Student)iterator.Next();
        if (currentStudent != null) {
          Console.Write(currentStudent.Name + "\t");
          Console.Write(currentStudent.Age + "\t");
          Console.Write(currentStudent.Height + "\t");
          Console.WriteLine(currentStudent.Weight);
        }
      }
    }
  }
}
