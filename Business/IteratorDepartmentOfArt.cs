using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Models;

namespace IteratorPattern.Business {
  class IteratorDepartmentOfArt : IIterator{
    private List<Student> _members;
    private int _position = 0;
    internal IteratorDepartmentOfArt(List<Student> members) {
      _members = members;
    }
    bool IIterator.HasNext() {
      if (_members.Count < _position) {
        return true;
      }
      else {
        return false;
      }
    }

    object IIterator.Next() {
      Student student = _members[_position];
      _position++;
      return student;
    }
  }
}
