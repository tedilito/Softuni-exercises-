using System.Threading.Channels;

Dictionary<string, Func<int, int>> commands = new Dictionary<string, Func<int, int>>
{
    ["add"] = x => x++,
    ["multyplt"] = x => x *= 2,
    ["subtract"] = x => x--,
    

};
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
string input;
while ((input = Console.ReadLine()) != "end")
{
    
}