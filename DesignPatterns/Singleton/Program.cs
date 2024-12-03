namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = SingletonPerson.CreatePerson("Ivan");
            var person1 = SingletonPerson.CreatePerson("Petur");
            var person2 = SingletonPerson.CreatePerson("Gosho");
            Console.WriteLine(person.Name);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
           
        }
    }
}
