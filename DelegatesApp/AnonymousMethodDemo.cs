using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WorkingWithDelegatesLibrary;

namespace DelegatesApp
{
    internal class AnonymousMethodDemo
    {
        static void Main(string[] args)
        {
            ConvertFullNameToUpperCase delobj = delegate (string s1, string s2) 
            {
                string name=s1.ToUpper();
              string lastname= s2.ToUpper();
                string fullname=string.Concat(name, lastname);
                Console.WriteLine(fullname);


            };

            delobj("Amit ", "Sharma");
            Console.WriteLine("------------------------");
            ConvertToUpperCase delobj1 = delegate (string s1, string s2)
            {
string s3=s1.ToUpper();
                string s4=s2.ToUpper();
                return string.Concat(s3, s4);   
            };
            string output=delobj1("Amita ", "Sharma");
            Console.WriteLine(output);

            Console.ReadLine();


            
        }
    }
}
