using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          

        }

        private static void ex14Palindrom()
        {
            //ex 14 palindrom
            int num, temp, remainder, reverse = 0;
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is  = {0}", reverse);
            if (temp == reverse)
                Console.WriteLine("Number is a palindrome \n");
            else
                Console.WriteLine("Number is not a palindrome \n");
            Console.ReadLine();
        }

        private static void ex13primenumber()
        {
            //ex13 prime or not
            Console.WriteLine("Introduceti numarul:");
            //Console.ReadLine();

            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }

        private static void ex12Armstrong()
        {
            //ex 12 Armstrong
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }

        private static void ex10removeduplicates()
        {
            //ex10 remove duplicate
            Console.WriteLine("Introduceti cuvantul");

            string str = Console.ReadLine();

            string result = "";
            result += str[0];

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] != str[i])
                    result += str[i];
            }

            Console.WriteLine(result);
        }

        private static void ex8Fibonacci()
        {
            //ex 8 Write a function to print the nth number in Fibonacci series
            int x = 0, y = 1, z = 0, nth, i;
            Console.WriteLine("\n\nPlease Enter The Term Number:");
            nth = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= nth; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }

            Console.WriteLine("\nthe {0}th term of Fibonacci Series is is {1}\n\n\n", nth, z);
        }

        private static void ex7Anagram()
        {
            //ex7 anagram

            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();


            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();


            Array.Sort(char1);
            Array.Sort(char2);


            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);


            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }


            Console.ReadLine();
        }
    }
}
