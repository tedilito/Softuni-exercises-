namespace GenericArrayCreator
{
    class StartUp
    {
        public static void Main()
        {
           
            string[] array = ArrayCreator.Create(5, "obicham te");
            Console.WriteLine(string.Join(" ", array));

        }
    }
}
