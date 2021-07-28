using IteratorPattern.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IteratorPattern.Models;

namespace IteratorPattern.Business {
  class DepartmentOfEducation : IDepartment {
    private Dictionary<string, Student> _members;
    internal DepartmentOfEducation() {
      _members = new Dictionary<string, Student>();
      AddMember("Nid", 21, 153, 42);
      AddMember("Yun", 21, 155, 41);
      AddMember("Sal", 20, 157, 40);
    }
    void AddMember(string name, int age, int height, int weight) {
      Student newStudent = new Student(name, age, height, weight);
      string key = newStudent.Name;
      if (_members.ContainsKey(key)) {
        key = $"{key}{_members.Count}";
      }
      else {
        // pass
      }
      _members.Add(key, newStudent);
    }

    IEnumerable IDepartment.CreateIterator() {
      IEnumerable componentList = new StudentEnumerable(_members);
      IEnumerator componentEnumerator = componentList.GetEnumerator();
      while (componentEnumerator.MoveNext()) {
        yield return (Component)componentEnumerator.Current;
      }
    }

    object IDepartment.GetMembers() {
      return _members;
    }
  }
}
