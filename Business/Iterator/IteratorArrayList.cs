using IteratorPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Business {
  class IteratorArrayList : IIterator {
    private ArrayList _members;
    private int _position = 0;

    internal IteratorArrayList(ArrayList member) {
      _members = member;
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
      object student = _members[_position];
      _position++;
      return student;
    }

    void IIterator.Remove() {
      if (_position <= 0) {
        throw new IndexOutOfRangeException("Can't remove am item before Next() is called");
      }
      else {
        _members.Remove((Student)_members[_position]);
      }
    }
  }
}
