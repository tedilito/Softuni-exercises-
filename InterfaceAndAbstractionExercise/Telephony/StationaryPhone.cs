using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    internal class StationaryPhone : BasePhone
    {
      
        public override void Call(string number)
        {
            if (IsCorrectNum(number))
            {

                Console.WriteLine($"Dialing... {number}");

            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public override bool IsCorrectNum(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
