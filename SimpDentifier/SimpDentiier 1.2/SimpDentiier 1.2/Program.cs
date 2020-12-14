using SimpDentiier_1._2.Information;
using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Threading;

namespace SimpDentifier_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Thank you for taking the SimpDentifier Test!");
            Console.ReadLine();
            Console.WriteLine("Patch Notes for 1.2.4.1\n Changed Algorithm for computaion of Sipmness percentage.\n Changed the system for answering the questions.\n Development is back on track.");
            Console.ReadLine();

            Console.WriteLine("Rules: \n0 means not at all and 10 means aboslutely.\nThe test is based in ranging and 5 is the middle point");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();



            int r, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, t;
            float p;
            string n;
            Console.Write("Enter Testee Number: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Have you ever ditched plans for a girl/boy?: ");
            q1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("do you usually discuss relationships with girls/boys?: ");
            q2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do You Hate Your Opposite Gender?: ");
            q3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Favorite Youtuber Has Channel Memberships on for a dollar, Will you pay for it?: ");
            q4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your friend who you have secret feelings for asked you a favor to treat her some Ice Cream,will you pay for it?: ");
            q5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Will you do anything for a best Friend?: ");
            q6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("A boy/girl your age walks up to you and introduces oneself. Will you do the same?: ");
            q7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("You saw (A Pregnant Woman/Old Man) standing on the bus, will you come to your senses, Give your chair up and be the good guy?: ");
            q8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Me a Number not exceceding 10: ");
            q9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now think of an even number. (still not exceeding 10): ");
            q10 = Convert.ToInt32(Console.ReadLine());
            t = q1 + q2 + q3 + q4 + q5 + q6 + q7 + q8 + q9 + q10;
            p = t / 1.0f;
            Console.WriteLine("Total: " + t);
            Console.WriteLine("Simpness Percentage: " + p + "%");
            Console.WriteLine(" ");


            if (p < 30 && p < 40)
            {
                Console.WriteLine("Low Probability");
            }
            else
            {

            }
            if (p >= 30 && p < 30)
            {
                Console.WriteLine("Probable Simp");

            }
            else
            {


            }
            if (p >= 50 && p <= 50)
            {
                Console.WriteLine("Middle Tier");

            }
            else
            {

            }
            if (p >= 60 && p <= 70)
            {
                Console.WriteLine("Simping is detected");
            }
            else
            {

            }
                if (p >= 80 && p <= 100)
                {
                    Console.WriteLine("Simp");
                }
                else
                {

                }
                Console.WriteLine("I hope you had fun using this.\n");
                Console.ReadLine();
                Console.WriteLine("Thank You For Taking the SimpDentifier Test");
                Console.ReadLine();
                Console.WriteLine(" \nVersion 1.2.4.1");
                Console.ReadLine();
                Console.WriteLine("Creator; SabSimp#9112");
                Console.ReadLine();
            }
        }
    }
