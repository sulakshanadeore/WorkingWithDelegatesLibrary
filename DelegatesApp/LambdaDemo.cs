using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApp
{
    internal class LambdaDemo
    {
        static void Main(string[] args)
        {

             double SquareOfNumber(int x)
            {

                return x * x;
            }

            //Last parameter in the declaration of Function lambda is return type
            Func<int, double> square = SquareOfNumber;
            double sqAns=square(10);
            Console.WriteLine(sqAns);
            //============================================================================================

            Func<int, int, double> addNos = (i, j) => {
                double additionAns = i + j;
                return additionAns;
            
            };


            double addAns=addNos(10, 20);
            Console.WriteLine(addAns);

            //===============================================================================================

            Func<string, string, string> concatStr = (s1, s2) => 
            {
                return string.Concat(s1, s2); 
            };

           string newstr= concatStr("HEllo", " Abhishek!!!!");
            Console.WriteLine(newstr);
            //----------------------------------------------

            Func<string, int> strLength = (s1) => { return s1.Length; };
            int len=strLength("Hello");
            Console.WriteLine(len);

            //---------------------------------------------------------------

            Action<string> strSub = (s1) =>
            {
                string mystr = s1.Substring(0, 4);
                Console.WriteLine(mystr);

            };

            strSub("GoodMorning");
            

            List<int> intlist=new List<int> { 1, 1, 1,1,1 };

           Console.WriteLine( intlist.Count);
            Console.WriteLine("---------------");


            intlist.ForEach(i=>Console.WriteLine(i));//Action lambda
            Console.WriteLine("--------------------------------");
            intlist.ForEach(i => { int k = i + 10;
                Console.WriteLine(k);
            });
            Console.WriteLine("----------------------");
            bool a=intlist.All(ele => { return ele > 10; });//func lambda with bool return type
            Console.WriteLine(a);

            Console.WriteLine("-------------------------");
            int no=intlist.Find(i => i == 11);//takes a condition and returning the same number
            Console.WriteLine("Number =" + no);

         int ansAggregate=   intlist.Aggregate((i, j) => { return i * j; });
            Console.WriteLine("Answer Aggregate= " + ansAggregate);



            //foreach (var item in intlist)
            //{
            //    Console.WriteLine(item);
            //}









            Console.Read();



        }

        
    }
}
