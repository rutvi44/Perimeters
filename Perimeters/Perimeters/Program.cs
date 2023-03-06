using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeters
{

        internal class Program
        {
            static void Main(string[] args)
            {
                string firstName, lastName;
                double num1, num2, num3;


                // Taking Input from users.
                Console.Write("Please enter your First Name: ");
                firstName = Convert.ToString(Console.ReadLine());

                Console.Write("Please enter your Last Name: ");
                lastName = Convert.ToString(Console.ReadLine());

                Console.Write("Please enter the legnth of Side a: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the legnth of Side b: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the legnth of Side c: ");
                num3 = Convert.ToDouble(Console.ReadLine());

                //Output 
                Console.WriteLine();
                Console.WriteLine();
                Print(firstName, lastName);
                Console.WriteLine($"\nThe perimeter of circle with diameter {num1} is: " + string.Format("{0:0.00}", (PeriMeter(num1))));
                Console.WriteLine($"The Perimeter of rectangle with sides {num1} and {num2} is: " + string.Format("{0:0.00}", (PeriMeter(num1, num2))));
                Console.WriteLine($"The Perimeter of triangle with sides {num1}, {num2} and {num3} is: " + string.Format("{0:0.00}", (PeriMeter(num1, num2, num3))));

                Console.ReadKey();
            }
            // Print Welcome to user.
            static void Print(string a, string b)
            {
                Console.WriteLine($"Welcome {a} {b} !");
            }
            // Calculate Perimeter of Circle.
            static double PeriMeter(double radius)
            {
                double periMeterCircle = Math.PI * radius;
                return periMeterCircle;
            }
            // Calculare Perimeter of Rectangle.
            static double PeriMeter(double legnth, double width)
            {
                double periMeterRectangle = (legnth + width) * 2;
                return periMeterRectangle;
            }
            // Calculate Perimeter of Triangle.
            static double PeriMeter(double a, double b, double c)
            {
                double periMeterTriangle = a + b + c;
                return periMeterTriangle;
            }
        }
    }