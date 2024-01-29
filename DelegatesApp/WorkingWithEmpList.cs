using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithDelegatesLibrary;

namespace DelegatesApp
{
    internal class WorkingWithEmpList
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>() {
            new Employee{Empid=1,EmpName="Archana",TotalLeaves=10 },
            new Employee{Empid=2,EmpName="Kalpana",TotalLeaves=1 },
            new Employee{Empid=3,EmpName="Suvarna",TotalLeaves=19 }
                        };
            //Find employeee with empid =1

            Employee empfound=emplist.Find(e=>e.Empid==4);
            Console.WriteLine(empfound.Empid);
            Console.WriteLine(empfound.EmpName);
            Console.WriteLine(empfound.TotalLeaves);
            Console.ReadLine();
        }
    }
}
