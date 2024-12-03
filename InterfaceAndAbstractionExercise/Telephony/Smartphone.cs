using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : BasePhone, IBrowse
    {


        public override void Call(string number)
        {
            if (IsCorrectNum(number))
            {

                Console.WriteLine($"Calling... {number}");

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

        public void Browse(string URL)
        {

            if (IsValidURL(URL))
            {
                Console.WriteLine($"Browsing: {URL}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }

        }

        public bool IsValidURL(string URL)
        {


            for (int i = 0; i < URL.Length; i++)
            {
                if (char.IsDigit(URL[i]))
                {
                    return false;
                }
            }
            return true;

        }
    }
}