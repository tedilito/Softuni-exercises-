using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>(buttonCapacity);
        }

        public int ButtonCapacity { get; set; }
        public List<Drink> Drinks { get; set; }

        public int GetCount
        {
            get { return Drinks.Count; }

        }

        public void AddDrink(Drink drink)
        {
            if (Drinks.Count < ButtonCapacity)
            {
                Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name)
        {
            return Drinks.Remove(Drinks.Where(x => x.Name == name).FirstOrDefault());
        }

        public Drink GetLongest()
        {
            return Drinks.OrderByDescending(x => x.Volume).FirstOrDefault();
        }

        public Drink GetCheapest()
        {
            return Drinks.OrderBy(x => x.Price).FirstOrDefault();
        }

        public string BuyDrink(string name)
        {
            return Drinks.Where(x => x.Name == name).FirstOrDefault().ToString();
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Drinks available:");
            foreach (var item in Drinks)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            return stringBuilder.ToString().Trim();
        }


    }
}
