string[] songs = Console.ReadLine().Split(", ");
Queue <string> queue = new Queue<string>(songs);
while (queue.Count > 0)
{
 
    string[] commands = Console.ReadLine().Split();
	switch (commands[0])
	{

		case "Play":
			queue.Dequeue();
			break;

		case "Add":
			string songToAdd = string.Empty ;
            for (global::System.Int32 i = 1; i < commands.Length; i++)
            {
				songToAdd += commands[i] + " ";
            }
			songToAdd = songToAdd.TrimEnd();
            if (!queue.Contains(songToAdd))
            {
				queue.Enqueue(songToAdd);
            }
			else
			{
                Console.WriteLine($"{songToAdd} is already contained!");
            }
            break;

		case "Show":
            Console.WriteLine(string.Join(", ", queue));
            break; 




		default:
			break;
	}
}
Console.WriteLine("No more songs!");