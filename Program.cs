using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Models;

namespace IteratorPattern {
  class Program {
    static void Main(string[] args) {
      Admin admin = new Admin();
      admin.PrintMembers();
      Console.ReadKey();
    }
  }
}
