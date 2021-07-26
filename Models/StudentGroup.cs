using IteratorPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Business {
  class StudentGroup : Component {
    private ArrayList _studentGroup = new ArrayList();
    private string _groupName;
    private string _description;
    public string GroupName => _groupName;
    public string Description => _description;
    public override string Name => throw new NotImplementedException();
    public override int Age => throw new NotImplementedException();
    public override int Height => throw new NotImplementedException();
    public override int Weight => throw new NotImplementedException();

    internal StudentGroup(string name, string description) {
      _groupName = name;
      _description = description;
    }
    public override void Add(Component component) {
      _studentGroup.Add(component);
    }
    public override void Remove(Component component) {
      _studentGroup.Remove(component);
    }
    public override void Print() {
      Console.WriteLine("------------------------- +++");
      Console.WriteLine(this.GroupName);
      Console.WriteLine(this.Description);
      Console.WriteLine("------------------------- +++");

      IIterator iterator = new IteratorArrayList(_studentGroup);
      while (iterator.HasNext()) {
        Component component = (Component)iterator.Next();
        if (component != null) {
          component.Print();
        }
      }
    }
  }
}
