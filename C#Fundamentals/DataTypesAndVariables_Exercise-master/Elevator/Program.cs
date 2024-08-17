namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = numPeople / capacity;
            int peopleLeft =  numPeople - (fullCourses * capacity);

            if (numPeople % capacity == 0)
            {
                Console.WriteLine(fullCourses);
            }
            else if (numPeople % capacity != 0)
            {
                Console.WriteLine(fullCourses+1);
            }



        }
    }
}
