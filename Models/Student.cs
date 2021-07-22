using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCompositePattern.Models {
  class Student {
    private string _name;
    private int _age;
    private int _height;
    private int _weight;
    internal Student(string name, int age, int height, int weight) {
      _name = name;
      _age = age;
      _height = height;
      _weight = weight;
    }
  }
}
