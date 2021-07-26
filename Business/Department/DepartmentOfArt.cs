using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Models;
using IteratorPattern;
using System.Collections;

namespace IteratorPattern.Business {
  class DepartmentOfArt : IDepartment {
    List<Student> _members;
    internal DepartmentOfArt() {
      _members = new List<Student>();
      AddMember("Yan", 21, 155, 45);
      AddMember("Sin", 20, 153, 47);
      AddMember("Yun", 19, 157, 44);
    }
    void AddMember(string name, int age, int height, int weight) {
      Student newStudent = new Student(name, age, height, weight);
      _members.Add(newStudent);
    }
    // Commented, exsposed internal implementation
    /*    internal List<Student> GetMembers() {
          return _members;
        }*/
/*    internal IIterator GetIterator() {
      return new IteratorDepartmentOfArt(_members);
    }*/
    IIterator IDepartment.CreateIterator() {
      return new IteratorDepartmentOfArt(_members);
    }
    IEnumerable IDepartment.CreateIterator(Component baseComponent) {
      IEnumerable componentList = new StudentEnumerable(_members);
      foreach (Component C in componentList) {
        baseComponent.Add(C);
      }
      return new StudentEnumerable(_members);
    }
    object IDepartment.GetMembers() {
      return _members;
    }
  }
}
