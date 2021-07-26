using IteratorPattern.Business;
using IteratorPattern.Models;
using System;

namespace IteratorPattern {
  class Run {
    private Component _theUniversity;
    private IDepartment _memberOfArt;
    private IDepartment _memberOfEng;
    private IDepartment _memberOfEdu;
    internal Run() {
      _theUniversity = new StudentGroup(
        name: "University", 
        description: "Student in the entire university");

      Component artDepartment = new StudentGroup(
        name: "Department of Art", 
        description: "Student of Department of Art");
      Component engDepartment = new StudentGroup(
        name: "Department of Engineering", 
        description: "Student of Department of Engineering");
      Component eduDepartment = new StudentGroup(
        name: "Department of Education", 
        description: "Student of Department of Education");


      _theUniversity.Add(artDepartment);
      _theUniversity.Add(engDepartment);
      _theUniversity.Add(eduDepartment);

      _memberOfArt = new DepartmentOfArt();
      _memberOfEng = new DepartmentOfEngineering();
      _memberOfEdu = new DepartmentOfEducation();

      AddIteratorMember(_memberOfArt.CreateIterator(), artDepartment);
      AddIteratorMember(_memberOfEng.CreateIterator(), engDepartment);
      AddIteratorMember(_memberOfEdu.CreateIterator(), eduDepartment);

      Admin admin = new Admin(_theUniversity);
      admin.PrintMembers();
    }

    void AddIteratorMember(IIterator iterator, Component baseComponent) {
      while (iterator.HasNext()) {
        Component currentStudent = (Component)iterator.Next();
        if (currentStudent != null) {
          baseComponent.Add(currentStudent);
        }
      }
    }
  }
}
