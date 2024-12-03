using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private double totalCalories;

        public Pizza(string name)
        {
            Name = name;
            Toppings = new List<Topping>();
        }

        public double TotalCalories => dough.Calories + toppings.Sum(t => t.TotalCalories);

        public List<Topping> Toppings
        {
            get => toppings;
            private set => toppings = value;
        }

        public Dough Dough
        {
            get => dough;
            set => dough = value;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories:F2} Calories.";
        }
    }
}
