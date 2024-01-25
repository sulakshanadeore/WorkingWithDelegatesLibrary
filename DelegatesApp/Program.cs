using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithDelegatesLibrary;
namespace DelegatesApp
{
    internal class Program
    {
        //declaration of the event
        static event DelegateForLeaveApprovalProcess ApplyForLeave;
        static void Main(string[] args)
        {
           // UnicastDelegateDemo();

            Employee empobj=new Employee();
            EmpFullNameAndLength delobj1 = new EmpFullNameAndLength(empobj.CreateFullName);
            EmpFullNameAndLength delobj2 = new EmpFullNameAndLength(empobj.CalculateLengthOfName);
            EmpFullNameAndLength delobjCombined=(EmpFullNameAndLength)MulticastDelegate.Combine(delobj1, delobj2);
            
            delobjCombined.Invoke("Amitabh ", "Bacchan");
            Console.WriteLine(empobj.EmpName);

            Console.Read();
        }

        private static void UnicastDelegateDemo()
        {
            Employee empobj = new Employee() { Empid = 1, EmpName = "Ajay", TotalLeaves = 10 };

            DelegateForLeaveApprovalProcess delobj = new DelegateForLeaveApprovalProcess(empobj.LeaveApproval);//reference of our method
            ApplyForLeave += delobj;
            Console.WriteLine("Do u want to apply for leave");
            bool userchoice = Convert.ToBoolean(Console.ReadLine());
            if (userchoice == true)
            {
                Console.WriteLine("For how many days u want leave");
                int leave = Convert.ToInt32(Console.ReadLine());
                bool ans = ApplyForLeave(leave);
                Console.WriteLine("Leave Approved= " + ans);
                Console.WriteLine($"Now the total leaves remaining ={empobj.TotalLeaves}");
            }
            else
            {
                Console.WriteLine("Ok...coming out of the leave application process");
            }
        }
    }
}
