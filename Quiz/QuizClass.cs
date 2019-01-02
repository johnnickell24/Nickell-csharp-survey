using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class QuizClass
    {
        //Contructor
        public QuizClass()
        {

        }

        //Method
        public void QuizStart()
        {
            int tmp = 1;
            int times = 0;

            int gwMax = 0;
            int econMax = 0;
            int warMax = 0;
            int healthMax = 0;
            int eduMax = 0;

            int gw1, gw2, gw3, gw4, gw5, gw6, gw7, gw8, gw9, gw10;
            gw1 = gw2 = gw3 = gw4 = gw5 = gw6 = gw7 = gw8 = gw9 = gw10 = 0;

            int econ1, econ2, econ3, econ4, econ5, econ6, econ7, econ8, econ9, econ10;
            econ1 = econ2 = econ3 = econ4 = econ5 = econ6 = econ7 = econ8 = econ9 = econ10 = 0;

            int war1, war2, war3, war4, war5, war6, war7, war8, war9, war10;
            war1 = war2 = war3 = war4 = war5 = war6 = war7 = war8 = war9 = war10 = 0;

            int health1, health2, health3, health4, health5, health6, health7, health8, health9, health10;
            health1 = health2 = health3 = health4 = health5 = health6 = health7 = health8 = health9 = health10 = 0;

            int edu1, edu2, edu3, edu4, edu5, edu6, edu7, edu8, edu9, edu10;
            edu1 = edu2 = edu3 = edu4 = edu5 = edu6 = edu7 = edu8 = edu9 = edu10 = 0;

            while (tmp == 1)
            {
                int num1;
                Console.WriteLine("On a scale of 1-10, how important is global warming?");
                num1 = Convert.ToInt32(Console.ReadLine());
                gwMax += num1;
                
                if (num1 == 1)
                {
                    gw1 += 1;
                }
                if (num1 == 2)
                {
                    gw2 += 1;
                }
                if (num1 == 3)
                {
                    gw3 += 1;
                }
                if (num1 == 4)
                {
                    gw4 += 1;
                }
                if (num1 == 5)
                {
                    gw5 += 1;
                }
                if (num1 == 6)
                {
                    gw6 += 1;
                }
                if (num1 == 7)
                {
                    gw7 += 1;
                }
                if (num1 == 8)
                {
                    gw8 += 1;
                }
                if (num1 == 9)
                {
                    gw9 += 1;
                }
                if (num1 == 10)
                {
                    gw10 += 1;
                }


                int num2;
                Console.WriteLine("On a scale of 1-10, how important is the economy?");
                num2 = Convert.ToInt32(Console.ReadLine());
                econMax += num2;

                if (num2 == 1)
                {
                    econ1 += 1;
                }
                if (num2 == 2)
                {
                    econ2 += 1;
                }
                if (num2 == 3)
                {
                    econ3 += 1;
                }
                if (num2 == 4)
                {
                    econ4 += 1;
                }
                if (num2 == 5)
                {
                    econ5 += 1;
                }
                if (num2 == 6)
                {
                    econ6 += 1;
                }
                if (num2 == 7)
                {
                    econ7 += 1;
                }
                if (num2 == 8)
                {
                    econ8 += 1;
                }
                if (num2 == 9)
                {
                    econ9 += 1;
                }
                if (num2 == 10)
                {
                    econ10 += 1;
                }

                int num3;
                Console.WriteLine("On a scale of 1-10, how important is war?");
                num3 = Convert.ToInt32(Console.ReadLine());
                warMax += num3;

                if (num3 == 1)
                {
                    war1 += 1;
                }
                if (num3 == 2)
                {
                    war2 += 1;
                }
                if (num3 == 3)
                {
                    war3 += 1;
                }
                if (num3 == 4)
                {
                    war4 += 1;
                }
                if (num3 == 5)
                {
                    war5 += 1;
                }
                if (num3 == 6)
                {
                    war6 += 1;
                }
                if (num3 == 7)
                {
                    war7 += 1;
                }
                if (num3 == 8)
                {
                    war8 += 1;
                }
                if (num3 == 9)
                {
                    war9 += 1;
                }
                if (num3 == 10)
                {
                    war10 += 1;
                }

                int num4;
                Console.WriteLine("On a scale of 1-10, how important is health care?");
                num4 = Convert.ToInt32(Console.ReadLine());
                healthMax += num4;

                if (num4 == 1)
                {
                    health1 += 1;
                }
                if (num4 == 2)
                {
                    health2 += 1;
                }
                if (num4 == 3)
                {
                    health3 += 1;
                }
                if (num4 == 4)
                {
                    health4 += 1;
                }
                if (num4 == 5)
                {
                    health5 += 1;
                }
                if (num4 == 6)
                {
                    health6 += 1;
                }
                if (num4 == 7)
                {
                    health7 += 1;
                }
                if (num4 == 8)
                {
                    health8 += 1;
                }
                if (num4 == 9)
                {
                    health9 += 1;
                }
                if (num4 == 10)
                {
                    health10 += 1;
                }

                int num5;
                Console.WriteLine("On a scale of 1-10, how important is education?");
                num5 = Convert.ToInt32(Console.ReadLine());
                eduMax += num5;

                if (num5 == 1)
                {
                    edu1 += 1;
                }
                if (num5 == 2)
                {
                    edu2 += 1;
                }
                if (num5 == 3)
                {
                    edu3 += 1;
                }
                if (num5 == 4)
                {
                    edu4 += 1;
                }
                if (num5 == 5)
                {
                    edu5 += 1;
                }
                if (num5 == 6)
                {
                    edu6 += 1;
                }
                if (num5 == 7)
                {
                    edu7 += 1;
                }
                if (num5 == 8)
                {
                    edu8 += 1;
                }
                if (num5 == 9)
                {
                    edu9 += 1;
                }
                if (num5 == 10)
                {
                    edu10 += 1;
                }

                Console.WriteLine("Enter more data? (1=yes, 0=no):");
                tmp = Convert.ToInt32(Console.ReadLine());

                times += 1;
            }


            string output1 = "global warming      " + gw1 + "   " + gw2 + "   " + gw3 + "   " + gw4 + "   " + gw5 + "   " + gw6 + "   " + gw7 + "   " + gw8 + "   " + gw9 + "   " + gw10 + "       " +  (gwMax/times);
            string output2 = "the economy         " + econ1 + "   " + econ2 + "   " + econ3 + "   " + econ4 + "   " + econ5 + "   " + econ6 + "   " + econ7 + "   " + econ8 + "   " + econ9 + "   " + econ10 + "       " + (econMax / times);
            string output3 = "war                 " + war1 + "   " + war2 + "   " + war3 + "   " + war4 + "   " + war5 + "   " + war6 + "   " + war7 + "   " + war8 + "   " + war9 + "   " + war10 + "       " + (warMax / times);
            string output4 = "health care         " + health1 + "   " + health2 + "   " + health3 + "   " + health4 + "   " + health5 + "   " + health6 + "   " + health7 + "   " + health8 + "   " + health9 + "   " + health10 + "       " + (healthMax / times);
            string output5 = "education           " + edu1 + "   " + edu2 + "   " + edu3 + "   " + edu4 + "   " + edu5 + "   " + edu6 + "   " + edu7 + "   " + edu8 + "   " + edu9 + "   " + edu10 + "       " + (eduMax / times);

            Console.WriteLine("Topic               1   2   3   4   5   6   7   8   9  10   Average");
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
            Console.WriteLine(output4);
            Console.WriteLine(output5);
            Console.WriteLine("\n");

            int max = 0;
            string name = "";

            if (gwMax > max)
            {
                max = gwMax;
                name = "global warming";
            }
            if (econMax > max)
            {
                max = econMax;
                name = "the economy";
            }
            if (warMax > max)
            {
                max = warMax;
                name = "war";
            }
            if (healthMax > max)
            {
                max = healthMax;
                name = "health care";
            }
            if (eduMax > max)
            {
                max = eduMax;
                name = "education";
            }

            Console.WriteLine("Highest points: " + name + " (" + max + ")");
            Console.WriteLine("\n");

            int min = gwMax;
            string name2 = "global warming";

            if (gwMax < min)
            {
                min = gwMax;
                name2 = "global warming";
            }
            if (econMax < min)
            {
                min = econMax;
                name2 = "the economy";
            }
            if (warMax < min)
            {
                min = warMax;
                name2 = "war";
            }
            if (healthMax < min)
            {
                min = healthMax;
                name2 = "health care";
            }
            if (eduMax < min)
            {
                min = eduMax;
                name2 = "education";
            }

            Console.WriteLine("Lowest Points " + name2 + " (" + min + ")");
            Console.WriteLine("\n");

        }
    }
}
