using DependecyInversion.Models;

namespace DependecyInversion.Repository
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAll();
        public void Add(Student student);

    }
}
