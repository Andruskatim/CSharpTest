using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace CSharpCourse
{
    class Program
    {

        public static bool ProgramFive()

        {
            Console.WriteLine("Перевод числа из метров в километры");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество метров: {0}", a);

            var b = a * 1000;
            Console.WriteLine(b);

            return true;
        }


    }



}
