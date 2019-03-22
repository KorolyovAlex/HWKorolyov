using System;

namespace DEV_3
{
    abstract class Employee
    {
        protected int salary;
        protected int productivity;
        protected PersonalData name;

        public Employee(string firstname, string lastname)
        {
            salary = 0;
            productivity = 0;
            name = new PersonalData(firstname, lastname);
        }

        public Employee()
        {
            salary = 0;
            productivity = 0;
        }

        public void EmployeeInfo()
        {
            Console.Write("{0} {1}", name.Firstname, name.Lastname);
        }

        public int Salary
        {
            get { return salary; }
        }

        public int Productivity
        {
            get { return productivity; }
        }
    }
}
