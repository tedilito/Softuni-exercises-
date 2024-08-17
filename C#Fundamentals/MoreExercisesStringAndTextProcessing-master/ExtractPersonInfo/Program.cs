using System.Text;

namespace ExtractPersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfNames = int.Parse(Console.ReadLine());
            //string name = string.Empty;
            //string age = string.Empty;
         
            for (int i = 0; i < numOfNames; i++)
            {
                StringBuilder names = new StringBuilder();
                StringBuilder ages = new StringBuilder();

                string text = Console.ReadLine();
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == '@')
                    {
                        while (text[j + 1] != '|')
                        {
                           // name += text[j + 1];
                            names.Append(text[j +1]);
                            j++;
                        }
                     
                    }

                    if (text[j] == '#' )
                    {
                        while (text[j + 1] != '*')
                        {
                          //  age += text[j + 1];
                            ages.Append(text[j + 1]);
                            j++;
                        }
                       
                    }

                }

                Console.WriteLine($"{names.ToString()} is {ages.ToString()} years old.");
            }

        }
    }
}
