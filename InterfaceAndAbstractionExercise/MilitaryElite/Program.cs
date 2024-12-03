namespace MilitaryElite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands;
            List<ISoldier> soldiers = new List<ISoldier>();
            
            List<Private> privates = new List<Private>();
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (arguments[0])
                {

                    case "Private":
                        Private privateSoldier = new Private(arguments[1], arguments[2], arguments[3], decimal.Parse(arguments[4]));
                        privates.Add(privateSoldier);
                        soldiers.Add(privateSoldier);
                        break;

                    case "LieutenantGeneral":
                        List<Private> privatesToAdd = new List<Private>();
                        for (global::System.Int32 i = 5; i < arguments.Length; i++)
                        {
                            privatesToAdd.Add(privates.Where(pr => pr.Id == arguments[i]).FirstOrDefault());
                        }
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(arguments[1], arguments[2], arguments[3], decimal.Parse(arguments[4]), privatesToAdd);
                        soldiers.Add(lieutenantGeneral);
                        break;

                    case "Engineer":
                        if (arguments[5] != "Airforces" && arguments[5] != "Marines")
                        {
                            continue;
                        }
                        Dictionary<string, string> repairs = new Dictionary<string, string>();
                        for (global::System.Int32 i = 6; i < arguments.Length; )
                        {
                            repairs.Add(arguments[i], arguments[i + 1]);
                            i += 2;
                        }

                        
                        Engineer engineer = new Engineer(arguments[1], arguments[2], arguments[3], decimal.Parse(arguments[4]), arguments[5], repairs);
                        soldiers.Add(engineer);
                        break;

                    case "Commando":
                        if (arguments[5] != "Airforces" && arguments[5] != "Marines")
                        {
                            continue;
                        }
                        Dictionary<string, string> missions = new Dictionary<string, string>();
                        for (global::System.Int32 i = 6; i < arguments.Length; )
                        {
                            if (arguments[i + 1] != "InProgress" && arguments[i + 1] != "Finished")
                            {
                                i += 2;
                                continue;
                            }
                              
                            missions.Add(arguments[i], arguments[i + 1]);
                            i += 2;
                            
                        }
                        Commando commando = new Commando(arguments[1], arguments[2], arguments[3], decimal.Parse(arguments[4]), arguments[5], missions);
                        soldiers.Add(commando);
                        break;

                    case "Spy":
                        Spy spy = new Spy(arguments[1], arguments[2], arguments[3], int.Parse(arguments[4]));
                         soldiers.Add(spy);
                        break;


                }

               
            }
            foreach (var item in soldiers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
