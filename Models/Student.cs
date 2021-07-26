using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models {
  class Student : Component {
    private string _name;
    private int _age;
    private int _height;
    private int _weight;

    public override string Name { get { return _name; } }
    public override int Age { get { return _age; } }
    public override int Height { get { return _height; } }
    public override int Weight { get { return _weight; } }

    internal Student(string name, int age, int height, int weight) {
      _name = name;
      _age = age;
      _height = height;
      _weight = weight;
    }

    public override void Add(Component component) {
      throw new NotImplementedException();
    }
    public override void Remove(Component component) {
      throw new NotImplementedException();
    }

    public override void Print() {
      Console.Write(this.Name + "\t");
      Console.Write(this.Age + "\t");
      Console.Write(this.Height + "\t");
      Console.WriteLine(this.Weight);
    }
  }
}
