using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace S6.Built_in_Interfaces
{
    internal class Employee : ICloneable , IComparable<Employee>
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

        public int CompareTo(Employee? other)
        {
            // Emp01.CompareTo(other)
            // 1 => This.Salary > other.Salary
            // -1 => This.Salary < other.Salary
            // 0 => This.Salary = other.Salary
            //if(this.Salary > other?.Salary)
            //    return 1;
            //else if(this.Salary < other?.Salary)
            //    return -1;
            //else 
            //    return 0;

            return this.Salary.CompareTo(other?.Salary);
        }


        //public int CompareTo(object? obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
