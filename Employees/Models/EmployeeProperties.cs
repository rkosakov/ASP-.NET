using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class EmployeeProperties
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        

    }

    public class Employee
    {
        // Declare generic List data type to hold employee details
        public List<EmployeeProperties> employeeList = new List<EmployeeProperties>();

        // Class constructor
        // Generate some employees by filling in details
        // The Add method of the List data type is used to do this
        public Employee()
        {
            employeeList.Add(new EmployeeProperties
            {
                Id = 1,
                FirstName = "Ivan",
                LastName = "Ivanov",
                Location = "Blagoevgrad",
                Email = "ii@gaga.com",
                Salary = 4000

            });
            employeeList.Add(new EmployeeProperties
            {
                Id = 2,
                FirstName = "Elena",
                LastName = "Elenova",
                Location = "Dupnitsa",
                Email = "ep@gaga.com",
                Salary = 3500

            });
            employeeList.Add(new EmployeeProperties
            {
                Id = 3,
                FirstName = "Petar",
                LastName = "Petrov",
                Location = "Simitli",
                Email = "pp@gaga.com",
                Salary = 3000
            });
            // ADD NEW EMPLOYEES HERE
            employeeList.Add(new EmployeeProperties
            {
                Id = 4,
                FirstName = "Rosen",
                LastName = "Kosakov",
                Location = "Sofia",
                Email = "rkosakov@gaga.com",
                Salary = 2700
            });
            employeeList.Add(new EmployeeProperties
            {
                Id = 5,
                FirstName = "Vasil",
                LastName = "Kosakov",
                Location = "Sofia",
                Email = "vkosakov@gaga.com",
                Salary = 3000
            });
            employeeList.Add(new EmployeeProperties
            {
                Id = 6,
                FirstName = "Violeta",
                LastName = "Kosakova",
                Location = "Plovdiv",
                Email = "vkosakova@gaga.com",
                Salary = 3500
            });
            employeeList.Add(new EmployeeProperties
            {
                Id = 7,
                FirstName = "Jim",
                LastName = "Kosakov",
                Location = "Burgas",
                Email = "jkosakov@gaga.com",
                Salary = 4000
            });
            employeeList.Add(new EmployeeProperties
            {
                Id = 8,
                FirstName = "Alice",
                LastName = "Kosakova",
                Location = "Ruse",
                Email = "akosakova@gaga.com",
                Salary = 5000
            });
            

               
        }

        // Method to add a new employee to list
        public void addNewEmployee(EmployeeProperties newEmployee)
        {

            
            employeeList.Add(newEmployee);

        }

        public IEnumerable<EmployeeProperties> LINQQuery()
        {
            var query = from emp in employeeList
                        where (emp.Salary > 3500 && emp.Salary < 4500 && emp.Location == "Blagoevgrad")
                        select emp;

            return query;
        }


        public EmployeeProperties getEmployee(int id)
        {
            EmployeeProperties details = employeeList.First<EmployeeProperties>(m => m.Id == id);
            return details;
        }

        

    }

}
