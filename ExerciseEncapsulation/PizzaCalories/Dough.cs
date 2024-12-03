using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int grams;
        private double calories;

        public Dough(string flourType, string bakingTechnique, int grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            WeightGrams = grams;
            Calories = CalculateCalories();
        }

        private double CalculateCalories()
        {
            double flourModifier = flourType.ToLower() == "white" ? 1.5 : 1.0;
            double techniqueModifier = bakingTechnique.ToLower() switch
            {
                "crispy" => 0.9,
                "chewy" => 1.1,
                "homemade" => 1.0,
                _ => throw new ArgumentException("Invalid baking technique.") // Added fallback for safety
            };

            return 2 * grams * flourModifier * techniqueModifier;
        }

        public double Calories
        {
            get => calories;
            private set => calories = value;
        }

        public int WeightGrams
        {
            get => grams;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                string lowerTechnique = value.ToLower();
                if (lowerTechnique != "crispy" && lowerTechnique != "chewy" && lowerTechnique != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value; // Preserve original casing
            }
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                string lowerFlourType = value.ToLower();
                if (lowerFlourType != "white" && lowerFlourType != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value; // Preserve original casing
            }
        }
    }
}
