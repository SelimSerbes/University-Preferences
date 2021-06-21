using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choices
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int[] result = new int[12];
            int[] result2 = new int[10];
            string[,] candidates2 = new string[10, 5];
            int[] correct = new int[12];
            int[] wrong = new int[12];
            string[,] studentno = new string[4, 4];
            int[] maxlist = new int[10];
            string[,] maxlist2 = new string[10, 2];
            string[,] assignment = new string[3, 4];
            int max;
            string[] choice = new string[10];
            string[] nolist = new string[10];
            char[] key = { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' };
            char[,] answer = { {'A', 'D', 'B', 'C', 'A', 'C', 'D', 'A', ' ', 'C', 'A', ' ', 'C', 'A', 'C', 'A', 'C', 'C', 'A', 'B' },
                               {'A', 'D', 'B', 'C', 'D', 'C', 'C', 'A', 'B', 'C', 'B', 'B', 'A', 'A', 'A', 'C', 'A', 'B', 'D', 'B' },
                               {'C', 'B', 'B', 'A', 'D', 'A', 'D', 'A', 'B', ' ', 'A', 'B', 'A', 'A', ' ', 'C', 'A', 'B', 'B', 'B' },
                               {' ', 'D', 'B', 'C', ' ', 'C', 'D', 'A', 'B', ' ', 'A', 'B', 'A', 'A', ' ', 'A', 'C', ' ', 'D', 'D' },
                               {'A', 'A', 'B', 'C', 'D', 'B', 'D', 'A', ' ', 'A', 'A', 'B', 'C', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                               {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'B', 'A', 'D', 'D' },
                               {'A', ' ', 'B', 'C', 'D', 'C', 'D', ' ', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                               {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'A', 'B', 'B', 'C', 'C', 'C', 'A', 'D', 'D' },
                               {'A', ' ', 'B', 'C', 'D', 'C', 'D', 'B', 'C', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', ' ', 'D' },
                               {'A', 'D', 'B', ' ', 'A', 'C', 'D', 'A', 'B', 'C', 'B', 'B', 'C', 'B', 'A', 'A', 'C', 'A', 'D', 'D' },
                               {'B', 'C', ' ', 'C', 'D', 'C', 'D', ' ', 'B', 'C', 'A', 'B', ' ', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                               {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'B', 'C', 'A', 'D', 'A' }};

            string[,] candidates = {{"2005","Ali Terim","2","3","1"},
                                    {"1844","Ece Yaman","2","1"," "},
                                    {"3020","Ege Soylu","2","3","1"},
                                    {"2280","Haydar Arslan","2","3","1"},
                                    {"5420","Muhammet Karakeçili","3","1",""},
                                    {"8716","Elif Kaya","1","2",""},                            //12 student
                                    {"1201","Selami Yazıcı","1","",""},
                                    {"4215","Gülten Neşedolu","2","2",""},
                                    {"5264","Ayşe Yıldız","1","3","2"},
                                    {"3542","Deniz Ovacıklı","2","3","1"},
                                    {"5726","Süleyman Karahan","3","1","3"},
                                    {"7120","Ilayda Çevik","1","2","3"}};

            string[,] departments = {{"1","COMPUTER ENGINEERING"},
                                     {"2","ELECTRONICS ENGINEERING"},
                                     {"3","MEDICINE"} };



            for (int k = 0; k < answer.GetLength(0); k++)
            {
                for (int i = 0; i < answer.GetLength(1); i++)
                {
                    if (answer[k, i] == key[i])
                    {
                        correct[k] += 1;                                       //result of exam score
                    }
                    else if (answer[k, i] != ' ' && answer[k, i] != key[i])
                    {
                        wrong[k] += 1;
                    }
                }
                result[k] = correct[k] * 5 - wrong[k] * 2;
            }



            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] >= 50)
                {
                    result2[s] = result[i];                                  //minimum score of 50 

                    for (int k = 0; k < candidates2.GetLength(1); k++)
                    {
                        candidates2[s, k] = candidates[i, k];             //temp candidates2 

                    }
                    s++;
                }
            }


            max = 0;
            int y = 0;
            for (int g = 0; g < maxlist.Length; g++)
            {

                for (int i = 0; i < maxlist.Length; i++)
                {
                    if (max < result2[i])
                    {
                        max = result2[i];                               //Sorting from large to small.
                    }
                }

                for (int n = 0; n < maxlist.Length; n++)
                {
                    if (result2[n] == max)
                    {
                        choice[y] = candidates2[n, 2];                                     
                        nolist[y] = candidates2[n, 0];
                        result2[n] = 0;
                        y++;
                    }
                }
                maxlist[g] = max;

                max = 0;
                                               
            }
            //Number,exam score,choice transfered to "maxlist" and "maxlist2" array.
            for (int g = 0; g < maxlist2.GetLength(0); g++)                                           
            {
                int i = 0;

                maxlist2[g, i] = nolist[g];
                maxlist2[g, i + 1] = choice[g];
                i++;
            }


            int t = 0;
            int d = 0;
            int f = 0;

            for (int i = 0; i < maxlist2.GetLength(0); i++)
            {


                if (maxlist2[i, 1] == "1")
                {
                    assignment[0, t] = maxlist2[i, 0];
                    t++;
                }
                else if (maxlist2[i, 1] == "2")                               //the part of choice.
                {
                    assignment[1, d] = maxlist2[i, 0];
                    d++;
                }
                else if (maxlist2[i, 1] == "3")
                {
                    assignment[2, f] = maxlist2[i, 0];
                    f++;
                }


            }



            Console.WriteLine("Number    Name & Surname        Score");
            for (int i = 0; i < result.Length; i++)
            {
                for (int k = 0; k < 2; k++)                                            //the part of listing.
                {
                    Console.Write(candidates[i, k] + "       ");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(34, i + 1);
                Console.Write(result[i]);
            }

            Console.WriteLine("\n");


            Console.WriteLine("No     Department                       Students");
            for (int i = 0; i < departments.GetLength(0); i++)
            {
                for (int k = 0; k < departments.GetLength(1); k++)
                {
                    Console.Write(departments[i, k] + "      ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < assignment.GetLength(0); i++)
            {
                
                Console.SetCursorPosition(40, 15 +i);
                for (int k = 0; k < assignment.GetLength(1); k++)
                {
                    
                    
                    Console.Write(assignment[i, k] + "   ");
                    
                }
            }

            Console.SetCursorPosition(55, 10);
            Console.Write("1. and 3.students who are below 50 point are not in the list.");

            Console.ReadLine();
        }
    }
}
