using System;

namespace LAB31
{
    class Program
    {


        static void Main(string[] args)
        {

            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            {
                double celsius = 0;

                if (fahrenheit < 45)
                {
                    Console.WriteLine("it is cold");
                }
                else if (fahrenheit >= 90)
                {
                    Console.WriteLine("it is hot");

                }


                celsius = (fahrenheit - 32d) * 5d / 9d;



            }


            int grade = 59;
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 0 - 59)
            {
                Console.WriteLine("Failed");
            }

            //             int speed = 42;

           // int speedlimit = 35;
            //if (speedlimit < speed)
            //{
                Console.WriteLine("slow now");
            // }
            //    string A = "Cat";
           // string B = "cat";
          //  int answers = 0;
           // answers = string.Compare(A, B);
           // Console.WriteLine(answers.ToString());












        }
    }
}


          
