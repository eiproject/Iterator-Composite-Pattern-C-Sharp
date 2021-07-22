using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models {
  class Student {
    private string _name;
    private int _age;
    private int _height;
    private int _weight;
    internal string Name { get { return _name; } }
    internal int Age { get { return _age; } }
    internal int Height { get { return _height; } }
    internal int Weight { get { return _weight; } }
    internal Student(string name, int age, int height, int weight) {
      _name = name;
      _age = age;
      _height = height;
      _weight = weight;
    }
  }
}
