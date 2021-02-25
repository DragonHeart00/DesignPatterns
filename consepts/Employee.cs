using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.consepts
{
    class Employee
    {
        private int empId;
        private string empName;
        private string company = "SAN";
        public double salary { get; set; }
        public int grade { get; set; }


        IEmail email;
        public Employee(int empId, string empName, IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployess()
        {
            email.SendEmail();
        }

    }


    class TestEmployee
    {
        static void Main(string[] args)
        {
            //SuperClass object = new SubClass();
            IEmail outlook = new OutlookEmail();
            Employee employee1 = new Employee(195462, "Sulaiman", outlook);
            employee1.salary = 1000;
            employee1.NotifyEmployess();

            IEmail gmail = new GmailEmail();
            Employee employee2 = new Employee(202020, "Alex", gmail);
            employee2.salary = 2000;
            employee2.NotifyEmployess();
        }
    }
}
