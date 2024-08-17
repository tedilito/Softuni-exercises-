using static Songs.Program;

namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Song> list = new List<Song>();
            for (int i = 0; i < numOfSongs; i++)
            {

                string[] commands = Console.ReadLine().Split("_").ToArray();
                string type = commands[0];
                string name = commands[1];
                string time = commands[2];
               Song song = new Song();
                song.typeList = type;
                song.name = name;
                song.time = time;
                list.Add(song);


            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.name);
                }
            }
            else
            {
                foreach (var songs in list)
                {
                    if (songs.typeList == typeList)
                    {
                        
                            Console.WriteLine(songs.name);
                        
                    }
                }


            }

        }
    }


    public class Song
    {
        public int numOfSongs { get; set; }
        public string typeList { get; set; }
        public string name { get; set; }
        public string time { get; set; }



    }
}

