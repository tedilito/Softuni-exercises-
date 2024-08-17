namespace articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            int numCommands = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < numCommands; i++)
            {
                string[] commandInfo = Console.ReadLine().Split(": ");
                string command = commandInfo[0];
                string argument = commandInfo[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChngAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }

           
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Contnetn { get; set; }
        public string Author { get; set; }

       public Article (string title, string contnetn, string author)
        {
            Title = title;
            Contnetn = contnetn;
            Author = author;

        }

        public void Edit(string newContent)
        {
            Contnetn = newContent;
        }

        public void ChngAuthor(string NewAuthor)
        {
            Author = NewAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

    }
}
