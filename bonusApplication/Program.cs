using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace bonusApplication
{
    class Bonus
    {
        static void Main(string[] args)
        {
            string name, firstString, secondString, thirdString, fourthString;
            int first, second, third, fourth, sum1, sum2, sum3, sum4;
            int product = 5;

            WriteLine("Enter your name...");
            name = ReadLine();
            WriteLine("Hello {0}!! Enter an integer....", name);
            firstString = ReadLine();
            first = Convert.ToInt32(firstString);
            WriteLine("Enter a second intger.... ");
            secondString = ReadLine();
            second = Convert.ToInt32(secondString);
            WriteLine("Enter a third integer....");
            thirdString = ReadLine();
            third = Convert.ToInt32(thirdString);
            WriteLine("Enter a fourth integer.....");
            fourthString = ReadLine();
            fourth = Convert.ToInt32(fourthString);

            sum1 = product * first;
            sum2 = product * second;
            sum3 = product * third;
            sum4 = product * fourth;

            WriteLine(sum1);
            WriteLine(sum2);
            WriteLine(sum3);
            WriteLine(sum4);
        }
    }
}
