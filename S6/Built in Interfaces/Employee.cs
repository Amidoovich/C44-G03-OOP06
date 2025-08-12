using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace S6.Built_in_Interfaces
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }


        public Employee()
        {

        }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public object Clone()
        {
            
            return new Employee(this);
            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //};
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name} , Salary = {Salary}";
        }

    }
}
