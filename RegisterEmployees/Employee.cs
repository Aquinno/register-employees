using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEmployees {
    internal class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name, int id, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void Increase(double percentage) {
            Salary += Salary * percentage / 100;
        }
    }
}


