HashSet<string> guests = new HashSet<string>();

HashSet<string> VipGuests = new HashSet<string>();


string input;

while ((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        VipGuests.Add(input);
    }
    else
    {
        guests.Add(input);
    }

}

while ((input = Console.ReadLine()) != "END")
{




    if (VipGuests.Contains(input) || guests.Contains(input))
    {
        if (VipGuests.Contains(input))
        {
            VipGuests.Remove(input);
        }
        else
        {
            guests.Remove(input);
        }
      
    }
    
   

}

Console.WriteLine(guests.Count + VipGuests.Count);

foreach (var item in VipGuests)
{

    Console.WriteLine(item);
}

foreach (var item in guests)
{
    Console.WriteLine(item);

}