using IteratorPattern.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern {
  class StudentEnumerable : IEnumerable {
    ArrayList _students = new ArrayList();

    public object StudentArray { get; }

    internal StudentEnumerable(List<Student> studentArray) {
      for (int i = 0; i < studentArray.Count; i++) {
        _students.Add(studentArray[i]);
      }
    }
    internal StudentEnumerable(Component[] studentArray) {
      for (int i = 0; i < studentArray.Length; i++) {
        _students.Add(studentArray[i]);
      }
    }
    internal StudentEnumerable(Dictionary<string, Student> studentArray) {
      for (int i = 0; i < studentArray.Count; i++) {
        _students.Add(studentArray.Values.ElementAt(i));
      }
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return (IEnumerator)GetEnumerator();
    }
    internal StudentEnumerator GetEnumerator() {
      return new StudentEnumerator(_students);
    }
  }

  class StudentEnumerator : IEnumerator {
    ArrayList _students;
    int _position = -1;
    internal StudentEnumerator(ArrayList studentList) {
      _students = studentList;
    }
    object IEnumerator.Current => _students[_position];

    bool IEnumerator.MoveNext() {
      _position++;
      return (_position < _students.Count);
    }

    void IEnumerator.Reset() {
      _position = -1;
    }
  }
}
