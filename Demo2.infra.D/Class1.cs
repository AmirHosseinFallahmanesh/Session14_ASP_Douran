using Demo.Core.Domain;
using Demo2.infra.EF;
using System;
using System.Collections.Generic;

namespace Demo2.infra.Data
{
    public class StudentRepository : IStudentRepositry
    {
        public StudentRepository(DemoContext demoContext)
        {
           demoContext.Set
        }
        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Student Create(Student student)
        {
            throw new NotImplementedException();
        }
    }

 
    public class UnitofWork
    {
        private readonly DemoContext demoContext;

        public UnitofWork(DemoContext demoContext)
        {
            StudentRepository = new StudentRepository(demoContext);
            this.demoContext = demoContext;
        }

        public StudentRepository StudentRepository { get; set; }

        public int SaveChanges()
        {
            return demoContext.SaveChanges();
        }

    }
}
