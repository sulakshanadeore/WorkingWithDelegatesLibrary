using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDelegatesLibrary
{
    public delegate bool DelegateForLeaveApprovalProcess(int noOfDays);

    public delegate void EmpFullNameAndLength(string Fname, string Lname);
    public class Employee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }

       
        public int TotalLeaves { get; set; }


        public void CreateFullName(string fname, string lname) {
            EmpName= string.Concat(fname, lname);
            
        }

        public void CalculateLengthOfName(string fname, string lname)
        {
          int namelength=string.Concat(fname, lname).Length;
            Console.WriteLine(namelength);
        }

            public bool LeaveApproval(int noOfDays)
        {
            bool leaveApprovalStatus = false;
        if (TotalLeaves > noOfDays)
            {
                Console.WriteLine("You can take a leave");
                TotalLeaves = TotalLeaves - noOfDays;
                leaveApprovalStatus = true;
            }
            else
            {
                Console.WriteLine("You can't take a leave... Leave not approved");

            }
        return leaveApprovalStatus;



        }

    }
}
