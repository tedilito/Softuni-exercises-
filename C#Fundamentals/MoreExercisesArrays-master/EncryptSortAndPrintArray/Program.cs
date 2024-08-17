


using System.Collections.Immutable;

namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] EncryptedValues = new int[n];
            for (int i = 0; i < n; i++)
            {
                string arr = Console.ReadLine();
                int valueVowel = 0;
                int valueConsonant = 0;
                int EncryptedValue = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    char currChar = arr[j];


                    if (currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u' || currChar == 'A' || currChar == 'E' || currChar == 'I' || currChar == 'O' || currChar == 'U')
                    {
                        valueVowel += (int)currChar * arr.Length;
                    }
                    else
                    {
                        valueConsonant += (int)currChar / arr.Length;
                    }

                }


                EncryptedValues[i] = valueVowel + valueConsonant;


            }

            Array.Sort(EncryptedValues);

            for (int i = 0; i < EncryptedValues.Length; i++)
            {
                Console.WriteLine(EncryptedValues[i]);
            }

        }

        
    }





}
