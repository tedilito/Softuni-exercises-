using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Queue<string> meals = new Queue<string>(Console.ReadLine().Split());
        Stack<int> dailyCaloriesIntake = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        Dictionary<string, int> mealCalories = new Dictionary<string, int>()
        {
            { "salad", 350 },
            { "soup", 490 },
            { "pasta", 680 },
            { "steak", 790 }
        };

        int countMeals = 0;

        while (meals.Count > 0 && dailyCaloriesIntake.Count > 0)
        {
            string currentMeal = meals.Peek();
            int mealCaloriesValue = mealCalories[currentMeal];
            int currentDayCalories = dailyCaloriesIntake.Pop();

            if (currentDayCalories >= mealCaloriesValue)
            {
                currentDayCalories -= mealCaloriesValue;
                meals.Dequeue();
                countMeals++;

                if (currentDayCalories > 0)
                {
                    dailyCaloriesIntake.Push(currentDayCalories);
                }
            }
            else
            {
                mealCaloriesValue -= currentDayCalories;
                meals.Dequeue();
                countMeals++;

                if (dailyCaloriesIntake.Count > 0)
                {
                    int nextDayCalories = dailyCaloriesIntake.Pop();
                    nextDayCalories -= mealCaloriesValue;
                    dailyCaloriesIntake.Push(nextDayCalories);
                }
            }
        }

        if (meals.Count == 0)
        {
            Console.WriteLine($"John had {countMeals} meals.");
            if (dailyCaloriesIntake.Count > 0)
            {
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dailyCaloriesIntake)} calories.");
            }
        }
        else
        {
            Console.WriteLine($"John ate enough, he had {countMeals} meals.");
            Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
        }
    }
}
