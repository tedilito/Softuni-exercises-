using System.Runtime.Versioning;
using System.Xml.Linq;
using static _4._Students.Program;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Students> students = new List<Students>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                string Name = commands[0];
                string LastName = commands[1];
                int ageInput = int.Parse(commands[2]);
                string townInput = commands[3];

                Students existingStudent = students.Find(s => s.FName == Name && s.LName == LastName);
                if (existingStudent != null)
                {
                    
                    existingStudent.Age = ageInput;
                    existingStudent.Town = townInput;
                }
                else
                {
                    // Create a new student
                    Students newStudent = new Students
                    {
                        FName = Name,
                        LName = LastName,
                        Age = ageInput,
                        Town = townInput
                    };
                    students.Add(newStudent);
                }
            }

            
            string townToSearch = Console.ReadLine();
            foreach(var student in  students)
            {
                if (student.Town == townToSearch)
                {
                    Console.WriteLine($"{student.FName} {student.LName} is {student.Age} years old.");
                }
            }

        }


        public class Students
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }



        }
    }
}
