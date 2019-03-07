using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_R
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("enter any number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("choose another number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"{num1} is larger than {num2}");
            else if (num2 > num1)
                Console.WriteLine("{0} is larger than {1}", num1, num2);
            else if (num1 == num2)
                Console.WriteLine("the numbers are equal");
            else
                Console.WriteLine("something wrong there");
            

            //task 2
            int myNum = 8;
          
            int userNum = 5;
         
            Console.WriteLine("guess my number");
            int guess = int.Parse(Console.ReadLine());

            if (guess == myNum)
                Console.WriteLine("yeah! you got it");
            else
            {
                if (guess < myNum)
                    Console.WriteLine("guess was too low");
                else if (guess > myNum)
                    Console.WriteLine("guess was too high");
            }
            Console.WriteLine("\nAnd here you have completed the guess game,Thanks,");
            
            //task 3
            Console.WriteLine("please enter the  final marks(out of 100) you attained in this course");
            int marks = int.Parse(Console.ReadLine());
            if (marks >= 90 && marks <= 100)
                Console.WriteLine("your grade is A+");
           else if (marks >= 80 && marks <= 89)
                Console.WriteLine("your grade is A");
            else if (marks >= 70 && marks <= 79)
                Console.WriteLine("your grade is B+");
             else if (marks >= 60 && marks <= 69)
                Console.WriteLine("your grade is B");
           else if (marks >= 50 && marks <= 59)
                Console.WriteLine("your grade is C");
            else if (marks >= 40 && marks <= 49)
                Console.WriteLine("your grade is D");
            else if (marks >= 0 && marks <= 39)
                Console.WriteLine("your grade is F");
            Console.ReadLine();

            








        }
    }
}
