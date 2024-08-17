using System.Numerics;

namespace FromLeftToRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                //BigInteger num1 = 0, num2 = 0;
                //bool isSecond = false;
                //int indexOfChar = 0;
                //string firstNum = "";
                //string secondNum = "";
                //BigInteger numTotal = 0;
                //string input = Console.ReadLine();
                //for (int l  = 0; l <= input.Length -1; l++)
                //{
                //    while (isSecond == false)
                //    {
                //        indexOfChar = input[l];

                //        firstNum += input[l];

                //        if (indexOfChar == 32)
                //        {
                //            l++;
                //            isSecond = true;
                //            break;

                //        }
                //        l++;
                //    }

                //   secondNum += input[l];



                //}

                //num1 = BigInteger.Parse(firstNum);
                //num2 = BigInteger.Parse(secondNum);
                //if (num1 > num2)
                //{
                //    while (num1 > 0)
                //    {
                //        numTotal += num1 % 10;
                //        num1 /= 10;


                //    }
                //    Console.WriteLine(numTotal);
                //}
                //else
                //{
                //    while (num2 > 0)
                //    {
                //        numTotal += num2 % 10;
                //        num2 /= 10;


                //    }
                //    Console.WriteLine(numTotal);
                //}

                string input = Console.ReadLine();
                string firstNumInString = "", secondNumInString = "";

                long num1 = 0, num2 = 0;
                long sumOfNums1 = 0, sumOfNums2 = 0;

                for (int j = 0; j < input.Length; j++)
                {

                    int AsciiValue = input[j];
                    while (AsciiValue != 32 )
                    {
                        firstNumInString += input[j];
                        AsciiValue = input[j];
                        j ++;
                    }
                    while (j < input.Length)
                    {
                        secondNumInString += input[j];
                        j++;
                    }
                  

                    num1 = long.Parse(firstNumInString);
                    num2 = long.Parse(secondNumInString);


                    if (num1 > num2)
                    {
                        while (num1 != 0)
                        {

                            sumOfNums1 += num1 % 10;
                            num1 /= 10;
                            
                        }
                        Console.WriteLine(sumOfNums1);
                    }
                    else if (num2 >= num1)
                    {
                        while (num2 != 0)
                        {

                            sumOfNums2 += num2 % 10;
                            num2 /= 10;
                            

                        }
                        Console.WriteLine(sumOfNums2);
                    }







                }
            }
        }
    }
}
