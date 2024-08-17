
using System.Globalization;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] Commands = input.Split();

                switch (Commands[0])
                {
                    case "exchange":
                        int index = int.Parse(Commands[1]);
                        arr = ExchnageArray(index, arr);

                        break;

                    case "max":

                        string type = Commands[1];
                        PrintMax(arr, type);


                        break;

                    case "min":
                        string Mintype = Commands[1];
                        PrintMin(arr, Mintype);
                        break;

                    case "first":
                        string firstType = Commands[2];
                        int count = int.Parse(Commands[1]);
                        PrintFirstElemnts(arr, firstType, count);
                        break;

                    case "last":
                        string LastType = Commands[2];
                        int countMin = int.Parse(Commands[1]);
                        PrintLastElemnts(arr, LastType, countMin);
                        break;

                    default:
                        break;
                }



            }
            Console.WriteLine($"[{string.Join(",", arr)}]");
        }

        private static void PrintLastElemnts(int[] arr, string lastType, int CounterNum)
        {

            if (CounterNum > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }


            string lastElements = "";
            int numConuter = 0;
            for (int i = arr.Length - 1; i <= 0; i++)
            {
                int number = arr[i];

                if (lastType == "even" && number % 2 == 0 || lastType == "odd" && number % 2 != 0)
                {

                    lastElements += $"{number}, " + lastElements;
                    numConuter++;

                    if (numConuter >= CounterNum)
                    {
                        break;
                    }

                }

                Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
            }
        }
        static void PrintFirstElemnts(int[] arr, string firstType, int count)
        {

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }




            string firstElements = "";
            int CounterNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];

                if (firstType == "even" && number % 2 == 0 || firstType == "odd" && number % 2 != 0)
                {

                    firstElements += $"{number}, ";
                    CounterNum++;

                    if (CounterNum >= count)
                    {
                        break;
                    }

                }

            }

            Console.WriteLine($"[{firstElements.TrimEnd(' ', ',')}]");
        }

        static void PrintMin(int[] arr, string Mintype)
        {
            int minIndex = -1;
            int minNum = int.MaxValue;


            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];

                if (Mintype == "even" && number % 2 == 0 || Mintype == "odd" && number % 2 != 0)
                {
                    if (number <= minNum)
                    {
                        minNum = number;
                        minIndex = i;
                    }
                }

            }

            if (minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintMax(int[] arr, string type)
        {
            int maxIndex = -1;
            int maxNum = int.MinValue;


            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];

                if (type == "even" && number % 2 == 0 || type == "odd" && number % 2 != 0)
                {
                    if (number >= maxNum)
                    {
                        maxNum = number;
                        maxIndex = i;
                    }
                }



                if (maxIndex != -1)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }

        }

        static int[] ExchnageArray(int index, int[] arr)
        {

            if (index >= 0 && index <= arr.Length)
            {
             
            }
            else
            {
                Console.WriteLine("invalid index");
                return arr;
            }

            int[] changedArr = new int[arr.Length];
            int changedIndex = 0;
            for (int i = index + 1; i <= arr.Length - 1; i++)
            {
                changedArr[changedIndex] = arr[i];
                changedIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                changedArr[changedIndex] = arr[i];
                changedIndex++;
            }
            return changedArr;
        }
    }
}
