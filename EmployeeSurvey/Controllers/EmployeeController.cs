using EmployeeSurvey.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeSurveyDbContext _context;

        public EmployeeController(EmployeeSurveyDbContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        public ActionResult<List<EmployeeDetail>> GetEmployees()
        {
            var employees = _context.EmployeeDetails.ToList();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<ActionResult<EmployeeDetail>> PostEmployee([FromBody]EmployeeDetail employee)
        {
            _context.EmployeeDetails.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.EmployeeDetails.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.EmployeeDetails.Remove(employee);
            await _context.SaveChangesAsync();
            return NoContent();
        }




    }
}
