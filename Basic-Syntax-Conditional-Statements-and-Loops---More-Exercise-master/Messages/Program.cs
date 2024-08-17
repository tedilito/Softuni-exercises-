namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < count; i++)
            {
                string clicked = Console.ReadLine();
                int mainNum = clicked[0] - '0';
                int lenght = clicked.Length;
                

                if (mainNum == 2)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "a";
                            break;
                        case 2:
                            result += "b";
                            break;

                        case 3:
                            result += "c";
                            break;

                            ;
                    }
                }
                else if (mainNum == 3)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "d";
                            break;
                        case 2:
                            result += "e";
                            break;

                        case 3:
                            result += "f";
                            break;

                            ;
                    }
                }
                else if (mainNum == 4)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "g";
                            break;
                        case 2:
                            result += "h";
                            break;

                        case 3:
                            result += "i";
                            break;

                            ;
                    }
                }
                else if (mainNum == 5)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "j";
                            break;
                        case 2:
                            result += "k";
                            break;

                        case 3:
                            result += "l";
                            break;

                            ;
                    }
                }
                else if (mainNum == 6)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "m";
                            break;
                        case 2:
                            result += "n";
                            break;

                        case 3:
                            result += "o";
                            break;

                            ;
                    }
                }
                else if (mainNum == 7)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "p";
                            break;
                        case 2:
                            result += "q";
                            break;

                        case 3:
                            result += "r";
                            break;

                        case 4:
                            result += "s";
                            break;
                    }
                }
                else if (mainNum == 8)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "t";
                            break;
                        case 2:
                            result += "u";
                            break;

                        case 3:
                            result += "v";
                            break;

                            ;
                    }
                }
                else if (mainNum == 9)
                {
                    switch (lenght)
                    {
                        case 1:
                            result += "w";
                            break;
                        case 2:
                            result += "x";
                            break;

                        case 3:
                            result += "y";
                            break;
                        case 4:
                            result += "z";
                            break;

                            ;
                    }
                }
                else if (mainNum == 0)
                {
                    
                       
                            result += " ";
                           
                     
                    
                }



            }
            Console.WriteLine(result);
        }
    }
}
