namespace MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string monthResult = "";

            switch (month)
            {

                case 1:
                    monthResult = "January";
                    break;

                case 2:
                    monthResult = "February";
                    break;

                case 3:
                    monthResult = "March";
                    break;

                case 4:
                    monthResult = "April";
                    break;

                case 5:
                    monthResult = "May";
                    break;
                case 6:
                    monthResult = "June";
                    break;
                case 7:
                    monthResult = "July";
                    break;
             
                case 8:
                    monthResult = "August";
                    break;

                case 9:
                    monthResult = "September";
                    break;
                case 10:
                    monthResult = "October";
                    break;
                case 11:
                    monthResult = "November";
                    break;
                case 12:
                    monthResult = "December";
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.WriteLine(monthResult);
        }
    }
}
