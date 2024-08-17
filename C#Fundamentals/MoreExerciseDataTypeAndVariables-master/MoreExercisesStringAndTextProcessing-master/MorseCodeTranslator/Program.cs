namespace MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseInput = Console.ReadLine().Split(new char[] { ' ' });
            string result = string.Empty;

            for (int i = 0; i < morseInput.Length; i++)
            {
                string morseLetters = string.Empty;


                switch (morseInput[i])
                {
                    case ".-": //a
                        result += "a";
                        break;

                    case "-...": //b
                        result += "b";
                        break;

                    case "-.-.": //c
                        result += "c";
                        break;

                    case "-..": //d\
                        result += "d";
                        break;


                    case ".": // e
                        result += "e";
                        break;

                    case "..-.": //f
                        result += "f";
                        break;


                    case "--.": //g
                        result += "g";
                        break;


                    case "....": // h
                        result += "h";
                        break;


                    case "..": // i
                        result += "i";
                        break;


                    case ".---": //j
                        result += "j";
                        break;

                    case "-.-": //k
                        result += "k";
                        break;


                    case ".-..": //l
                        result += "l";
                        break;


                    case "--": //m
                        result += "m";
                        break;

                    case "-.": //n
                        result += "n";
                        break;

                    case "---": //o
                        result += "o";
                        break;

                    case ".--.": //p
                        result += "p";
                        break;

                    case "--.-": //Q
                        result += "q";
                        break;

                    case ".-.": //r
                        result += "r";
                        break;

                    case "...": //s
                        result += "s";
                        break;


                    case "-": //T
                        result += "t";
                        break;


                    case "..-": //U
                        result += "u";
                        break;

                    case "...-": //v
                        result += "v";
                        break;


                    case ".--": //W
                        result += "w";
                        break;

                    case "-..-": //x
                        result += "x";
                        break;

                    case "-.--": //y
                        result += "y";
                        break;

                    case "--..": //z
                        result += "z";
                        break;

                    case "|":
                        result += "|";
                        break;




                    default:
                        break;
                }


            }
            result = result.Replace("|", " ");
            result = result.ToUpper();
            Console.WriteLine(result);

        }
    }
}
