using IteratorPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Business {
  class IteratorDepartmentOfEducation : IIterator{
    private Dictionary<string, Student> _members;
    private int _position = 0;
    internal IteratorDepartmentOfEducation(Dictionary<string, Student> members) {
      _members = members;
    }

    bool IIterator.HasNext() {
      if (_members.Count > _position) {
        return true;
      }
      else {
        return false;
      }
    }

    object IIterator.Next() {
      Student student = _members.Values.ElementAt(_position);
      _position++;
      return student;
    }

    void IIterator.Remove() {
      if (_position <= 0) {
        throw new IndexOutOfRangeException("Can't remove am item before Next() is called");
      }
      else {
        _members.Remove(_members.Keys.ElementAt(_position));
      }
    }
  }
}
