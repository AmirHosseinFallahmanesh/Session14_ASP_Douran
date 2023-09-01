using Demo.Core.Domain;
using Demo2.infra.Data;
using Demo2.infra.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo2.Core.App
{
    public class StudentFacade
    {
        private readonly UnitofWork unitofWork;

        public StudentFacade(UnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        public List<Student> GetAll()
        {
            return unitofWork.StudentRepository.GetStudents();
        }

        public Student Create(Student student)
        {
            
           var res= unitofWork.StudentRepository.Create(student);
            unitofWork.SaveChanges();
            return res;

        }
    }
    
    public class StudentFacade1
    {
        private readonly IUnitofWork unitofWork;

        public StudentFacade1(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        public List<Student> GetAll()
        {
            return unitofWork.Set<Student>().ToList();
        }

        public Student Create(Student student)
        {
            
           var res= unitofWork.Set<Student>().Add(student);
            unitofWork.SaveChanges();
            return student;

        }
    }
}
