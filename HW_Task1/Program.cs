using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.Write("Введите стартовое число: ");
                int numStart = Convert.ToInt32(Console.ReadLine());
                int numNow = numStart;
                Console.Write("Введите шаг: ");
                int numStep = Convert.ToInt32(Console.ReadLine());
                string keyLog;

                ArithProgression arith = new ArithProgression();
                GeomProgression geom = new GeomProgression();
                arith.SetStart(numStart);
                arith.setStep(numStep);
                geom.SetStart(numStart);
                geom.setStep(numStep);
                bool flag = false;
                do
                {
                    Console.WriteLine("наЖмите + для получения числа в арифметической прогрессии\nнаЖмите * для получения числа в геометрической прогрессии\nнаЖмите 0 для сброса\nнаЖмите N для выхода");
                    keyLog = Convert.ToString(Console.ReadLine());

                    if (keyLog == "+")
                        Console.WriteLine(arith.GetNext());
                    else if (keyLog == "*")
                        Console.WriteLine(geom.GetNext());
                    else if (keyLog == "0")
                    {
                        Console.WriteLine(arith.Reset());
                        flag = true;
                    }
                    else if (keyLog == "N")
                    {
                        flag = true;
                        exit = true;
                    }

                    else
                        Console.WriteLine("Попробуйте еще раз");
                }
                while (flag == false);
            }
            while (exit == false);
            Console.ReadKey();
        }
    }
}
