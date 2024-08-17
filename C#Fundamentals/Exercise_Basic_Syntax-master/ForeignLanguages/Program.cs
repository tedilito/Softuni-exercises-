namespace ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string spokenLanguages = string.Empty;

            if (Name == "England" || Name == "USA")
            {
                spokenLanguages = "English";
            }
            else if (Name == "Spain" || Name == "Argentina" || Name == "Mexico")
            {
                spokenLanguages = "Spanish";

            }
            else 
            {
                Console.WriteLine("unknown");
            }

            Console.WriteLine(spokenLanguages);
        }
    }
}
