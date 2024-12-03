using PizzaCalories;

public class StartUp
{
    public static void Main()
    {
        string[] commands = Console.ReadLine().Split();
        Pizza pizza = null;

        try
        {
            if (commands[0] == "Pizza")
                pizza = new Pizza(commands[1]);

            while ((commands = Console.ReadLine().Split())[0] != "END")
            {
                if (commands[0] == "Dough")
                {
                    pizza.Dough = new Dough(commands[1], commands[2], int.Parse(commands[3]));
                }
                else if (commands[0] == "Topping")
                {
                    pizza.AddTopping(new Topping(commands[1], int.Parse(commands[2])));
                }
            }

            Console.WriteLine(pizza);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
