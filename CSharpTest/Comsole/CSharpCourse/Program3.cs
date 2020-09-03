using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Runtime.CompilerServices;

namespace CSharpCourse
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Выберите программу от 1 до 9. Нажммите 0, чтобы выйти.");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {

                case 1:
                    Programs.ProgramTwo();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 2:
                    Programs.ProgramThree();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 3:
                    Programs.ProgramFour();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 4:
                    Programs.ProgramFive();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 5:
                    Programs.ProgramSix();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 6:
                    Programs.ProgramSeven();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 7:
                    Programs.ProgramEight();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 8:
                    Programs.ProgramNine();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                case 9:
                    Programs.ProgramTen();
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadLine();
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение");
                    Console.Clear();
                    CSharpCourse.Program1.Main();
                    break;
            }

        }
    }

    public class Programs
    {

         public static bool ProgramTwo()
            {

            Console.WriteLine("Введите пятизначное число: {0}");

                string num = Console.ReadLine();
                Convert.ToInt32(num);

                int a = num[0];
                Console.WriteLine(value: a);
                Console.WriteLine(num.Length);

                int b = num[1];
                Console.WriteLine(b);
                Console.WriteLine(num.Length);

                int c = num[2];
                Console.WriteLine(c);
                Console.WriteLine(num.Length);

                int d = num[3];
                Console.WriteLine(d);
                Console.WriteLine(num.Length);

                int e = num[4];
                Console.WriteLine(e);
                Console.WriteLine(num.Length);
                return true;
            }


           public static bool ProgramThree()
            {
                Console.WriteLine("Введите цифры a, b и c: ");

                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
                Console.WriteLine("c = {0}", c);


                Console.WriteLine("Высчитываем по формуле: (a + b — c / a) + c * a * a — (a + b)");

                var x = (a + b - c / a) + c * a * a - (a + b);

                Console.WriteLine("x = {0}", x);
                return true;
            }

            public static bool ProgramFour()
            {
                Console.WriteLine("Введите латинскую букву нижнего регистра:");
                string a = Console.ReadLine();
                Console.WriteLine("Буква нижнего регистра: {0}", a);

                string b = a.ToUpper();
                Console.WriteLine("Та же буква в верхнем регистре: {0}", b);
                return true;
            }


            public static bool ProgramFive()

            {
                Console.WriteLine("Перевод числа из метров в километры");

                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество метров: {0}", a);

                var b = a * 1000;
                Console.WriteLine(b);

                return true;
            }

            // Тут я понял, что надо еще гуглить, потому что непонятно пока как сделать

          public static bool ProgramSix()

          {
             // char(158);


              return true;
          }
            

            //   А эти два сделаю после предыдущего      

         public static bool ProgramSeven()
         {

             return true;
         }

         public static bool ProgramEight()
         {

             return true;
         }
            


            public static bool ProgramNine()
            {

                Console.WriteLine("Сравнение чисел используя оператор ветвления");

                Console.WriteLine("Введите 1 число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("a = {0}", a);

                Console.WriteLine("Введите 2 число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b = {0}", b);

                switch (a)
                {
                    case var _ when a > b:
                        Console.WriteLine("Больше");
                        break;
                    case var _ when a < b:
                        Console.WriteLine("Меньше");
                        break;
                    default:
                        Console.WriteLine("Равны");
                        break;
                }

                return true;
            }

            public static bool ProgramTen()
            {
                Console.WriteLine("Введите 1 число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("a = {0}", a);

                Console.WriteLine("Введите 2 число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b = {0}", b);

                Console.WriteLine("Введите 3 число:");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c = {0}", c);

                if (a == b || a == c || b == c)
                {
                    Console.WriteLine(a + 5);
                    Console.WriteLine(b + 5);
                    Console.WriteLine(c + 5);
                }
                else
                {
                    Console.WriteLine("Равных нет");
                }

                return true;
            }
     }
    
}    
