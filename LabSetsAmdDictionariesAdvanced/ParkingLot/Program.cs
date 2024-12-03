HashSet<string> parking = new HashSet<string>();

string input; 
while ((input = Console.ReadLine()) != "END")
{
    string[] commands = input.Split(", ");
    string  inOrOut = commands[0];
    string plate = commands[1];
    if (inOrOut == "IN")
    {
        parking.Add(plate);
    }
    else
    {
        parking.Remove(plate);
    }
}
if (parking.Count > 0)
{


    foreach (var item in parking)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
