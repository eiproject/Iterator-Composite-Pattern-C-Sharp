using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCompositePattern.Models {
  class DepartmentOfArts {
    List<Student> _members;
    internal DepartmentOfArts() {
      _members = new List<Student>();
      AddMember("Yan", 21, 155, 45);
      AddMember("Sin", 20, 153, 47);
      AddMember("Yun", 19, 157, 44);
    }
    void AddMember(string name, int age, int height, int weight) {
      Student newStudent = new Student(name, age, height, weight);
      _members.Add(newStudent);
    }
    internal List<Student> GetMembers() {
      return _members;
    }
  }
}
