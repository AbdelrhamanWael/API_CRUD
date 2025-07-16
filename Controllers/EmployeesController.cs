using API_CRUD_Operations.Data;
using API_CRUD_Operations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_Operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {

            var employees = dbContext.Employees.ToList();
            // Logic to retrieve all employees
            return Ok(employees);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }


        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employee = new Models.Entities.Employee
            {

                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return Ok(employee);

        }


        [HttpPut("{id:guid}")]

        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.Name =  updateEmployeeDto.Name;
            employee.Email =  updateEmployeeDto.Email;
            employee.Phone =  updateEmployeeDto.Phone;
            employee.Salary =  updateEmployeeDto.Salary;
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return NoContent();
        }


    }
}
