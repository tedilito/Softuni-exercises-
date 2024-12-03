namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] URLs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < nums.Length; i++)
            {
                
                if (nums[i].Length == 7)
                {
                    StationaryPhone stp = new StationaryPhone();
                    stp.Call(nums[i]);
                }
                else
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.Call(nums[i]);
                }
              
            }
            for (int i = 0; i < URLs.Length; i++)
            {
                Smartphone smartphone = new Smartphone();

                smartphone.Browse(URLs[i]);
            }
        }
    }
}
