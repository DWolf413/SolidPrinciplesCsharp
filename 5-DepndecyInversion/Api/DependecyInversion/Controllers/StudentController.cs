using DependecyInversion.Models;
using DependecyInversion.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInversion.Controllers
{
    [ApiController, Route("student")]
    public class StudentController : ControllerBase
    {
        StudentRepository studentRepository = new StudentRepository();
        Logbook logbook = new Logbook();

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            logbook.Add($"returning student's list");
            return studentRepository.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Student student)
        {
            studentRepository.Add(student);
            logbook.Add($"The Student {student.Fullname} have been added");
        }
    }
}
