using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AChuper aChuper = new AChuper();
            Console.WriteLine(aChuper.Encod("ABCD XYZ")) ;
            BChuper bChuper = new BChuper();
            Console.WriteLine(bChuper.Encod("ABCD XYZ"));
            Console.ReadKey();
        }
    }
}
