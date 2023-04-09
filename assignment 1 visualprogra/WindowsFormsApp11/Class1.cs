using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee() { }
        public Employee(int id,string name,DateTime dof)
        {
            Id = id;
            Name = name;
            DateOfBirth = dof;
        }
        public string EmployeeInfo()
        {
            return "employee id:" +Id + "\n"+
                "employee name:" + Name + "\n"+
                "date of birth:" + DateOfBirth.ToShortDateString();
        }







    }
}
