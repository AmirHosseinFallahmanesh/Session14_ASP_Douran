using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StdController : ControllerBase
    {
        private readonly StudentContext context;

        public StdController(StudentContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Student> GetAll() => context.Student.ToList();


        [HttpGet("{id}")]
        public Student Get(int id) => context.Student.Find(id);



        [HttpPost]
        public int Create(Student student)
        {
            context.Student.Add(student);
            context.SaveChanges();
            return student.StudentId;
        }
    }
}
