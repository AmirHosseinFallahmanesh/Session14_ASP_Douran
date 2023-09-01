using Demo.Core.Domain;
using System.Collections.Generic;

namespace Demo2.infra.Data
{
    public interface IStudentRepositry
    {
         List<Student> GetStudents();
    }

   
}
