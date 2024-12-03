using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string typeOfTopping;
        private int grams;
        private double totalCalories;

        public Topping(string typeOfTopping, int grams)
        {
            TypeOfTopping = typeOfTopping;
            Grams = grams;
            CalculateCalories();
        }

        private void CalculateCalories()
        {
            double modifier = typeOfTopping.ToLower() switch
            {
                "meat" => 1.2,
                "veggies" => 0.8,
                "cheese" => 1.1,
                "sauce" => 0.9,
                _ => throw new ArgumentException("Invalid topping type.") // Extra safety
            };
            totalCalories = 2 * grams * modifier;
        }

        public double TotalCalories => totalCalories;

        public string TypeOfTopping
        {
            get => typeOfTopping;
            private set
            {
                string lowerType = value.ToLower();
                if (lowerType != "meat" && lowerType != "veggies" && lowerType != "cheese" && lowerType != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                typeOfTopping = value; // Preserve original casing
            }
        }

        public int Grams
        {
            get => grams;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{typeOfTopping} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }
    }
}
