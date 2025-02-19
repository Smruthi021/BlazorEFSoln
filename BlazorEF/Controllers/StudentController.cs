using BlazorEF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace BlazorEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public List<StudTable> GetEmp()
        {
            StudentdatabaseContext context = new StudentdatabaseContext();
            return context.StudTables.ToList();

            //return context.EmpTables.Where(x => x.Salary > 8000).ToList();
        }
        [HttpGet("api/Student/{age}")]
        public async Task<ActionResult<StudTable>> GetStudentByAge(int age)
        {
            using (var context = new StudentdatabaseContext())
            {
                var student = await context.StudTables.FindAsync(age);
                if (student == null)
                {
                    return NotFound(); // Return a 404 if not found
                }
                return Ok(student); // Return the found student
            }
        }

        [HttpPost]
        public int AddStud(StudTable stu)
        {
            StudentdatabaseContext context = new StudentdatabaseContext();
            context.StudTables.Add(stu);
            context.SaveChanges();

            return stu.Age;
        }
        [HttpPut("{age}")]
        public IActionResult PutEmp(int age,StudTable updatedStudent)
        {
            using(StudentdatabaseContext context=new StudentdatabaseContext())
            {
                var existingStudent = context.StudTables.Find(age);
                if (existingStudent == null)
                {
                    return NotFound();
                }

                existingStudent.Name = updatedStudent.Name;

                context.SaveChanges();
                return NoContent();
            }
        }
        [HttpDelete("{age}")]
        public IActionResult DeleteEmp(int age)
        {
            using(StudentdatabaseContext context=new StudentdatabaseContext())
            {
                var existingStudent = context.StudTables.Find(age);
                if (existingStudent == null)
                {
                    return NotFound();
                }
                context.StudTables.Remove(existingStudent);
                context.SaveChanges();
                return NoContent();

            }
        }
        
    }
}
