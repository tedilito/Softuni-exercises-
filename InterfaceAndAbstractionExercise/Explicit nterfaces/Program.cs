namespace Explicit_nterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var parts = input.Split();
                string name = parts[0];
                string country = parts[1];
                int age = int.Parse(parts[2]);


                Citizen citizen = new Citizen(name, country, age);


                IPerson person = citizen;
                Console.WriteLine(person.GetName());

                IResident resident = citizen;
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
