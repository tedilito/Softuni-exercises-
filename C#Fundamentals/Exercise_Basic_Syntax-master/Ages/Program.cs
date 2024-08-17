namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int age =  int.Parse(Console.ReadLine());
            string typeOf = "";
            if (age >= 0 && age <= 2)
            {
                typeOf = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                typeOf = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                typeOf = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                typeOf = "adult";
            }
            else if (age > 65)
            {
                typeOf = "elder";
            }

            Console.WriteLine(typeOf);
        }
    }
}
