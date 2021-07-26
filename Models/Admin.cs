using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Business;

namespace IteratorPattern.Models {
  class Admin {
    private IDepartment _memberOfArt;
    private IDepartment _memberOfEng;
    private IDepartment _memberOfEdu;

    internal Admin() {
      _memberOfArt = new DepartmentOfArt();
      _memberOfEng = new DepartmentOfEngineering();
      _memberOfEdu = new DepartmentOfEducation();
    }
    internal void PrintMembers() {
      IIterator iteratorOfArt = _memberOfArt.CreateIterator();
      IIterator iteratorOfEng = _memberOfEng.CreateIterator();
      IIterator iteratorOfEdu = _memberOfEdu.CreateIterator();

      Console.WriteLine("Members from Department of Art");
      Console.WriteLine("Name\tAge\tHeight\tWeight");
      PrintMembers(iteratorOfArt);
      Console.WriteLine("\nMembers from Department of Engineering");
      Console.WriteLine("Name\tAge\tHeight\tWeight");
      PrintMembers(iteratorOfEng);
      Console.WriteLine("\nMembers from Department of Education");
      Console.WriteLine("Name\tAge\tHeight\tWeight");
      PrintMembers(iteratorOfEdu);
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
