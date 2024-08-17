using System.Collections.Generic;
using System.Globalization;

namespace ListManipulationAdvanced
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {

                string[] commands = input.Split();
                string task = commands[0];

                if (task == "Contains")
                {
                    int num = int.Parse(commands[1]);
                    if (list.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }


                }
                else if (task == "PrintEven")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write(list[i] + " ");
                                                        
                        }
                    }
                    Console.WriteLine();
                }
                else if (task == "PrintOdd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write(list[i] + " ");
                           
                        }
                    }
                    Console.WriteLine();
                }
                else if (task == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum += list[i];
                    }
                    Console.WriteLine(sum);

                }
                else if (task == "Filter")
                {
                    string condition = commands[1];
                    int num = int.Parse(commands[2]);


                    switch (condition)
                    {

                        case "<":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] < num)
                                {
                                    Console.Write(list[i] + " ");
                                   
                                }
                            }
                            Console.WriteLine();
                            break;

                        case ">":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > num)
                                {
                                    Console.Write(list[i] + " ");
                                    
                                }
                            }
                            Console.WriteLine();
                            break;

                        case ">=":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] >= num)
                                {
                                    Console.Write(list[i] + " ");
                                    
                                }
                                

                            }
                            Console.WriteLine();
                            break;


                        case "<=":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] <= num)
                                {
                                    Console.Write(list[i] + " ");
                                    
                                }
                                
                            }
                            Console.WriteLine();
                            break;

                        default:
                            break;
                    }






                }
            }

            
        }
    }
}


