using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Employee
    {
        public string Name;
        public double BasicSalary;
        public double HomeRent;
        public double MedicalAllowance;
        private double Salary;

        public double CalculateSalary()
        {
            HomeRent = BasicSalary * HomeRent / 100;
            MedicalAllowance = BasicSalary * MedicalAllowance / 100;
            Salary = BasicSalary + HomeRent + MedicalAllowance;
            return Salary;
        }
    }
}
