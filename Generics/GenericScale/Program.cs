namespace GenericScale
{
    class StartUp
    {
        public static void Main()
        {
            EqualityScale<int> scale = new EqualityScale<int>(10, 10);
            Console.WriteLine(scale.AreEqual()); 
        }
    }
}