namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int inputAge = int.Parse(Console.ReadLine());
            string Ages = string.Empty;

            if (inputAge >= 0 && inputAge <= 2)
            {
                Ages = "baby";
            }
            else if (inputAge > 2 && inputAge <= 13)
            {
                Ages = "child";
            }
            else if(inputAge > 13 && inputAge <= 19)
            {
                Ages = "teenager";
            }
            else if (inputAge > 19  && inputAge <= 65)
            {
                Ages = "adult";
            }
            else if (inputAge >= 65)
            {
                Ages = "elder";
            }
            Console.WriteLine(Ages);
        }
    }
}
