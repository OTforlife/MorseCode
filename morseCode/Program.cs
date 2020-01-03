using System;

namespace morseCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your message.");
            string message = Console.ReadLine();
            string messageCaps = message.ToUpper();
            string outString = "";

            for (int i = 0; i < messageCaps.Length; i++)
            {
                
                
                switch(messageCaps[i])
                {
                    case 'A':
                        outString += (".- ");
                        break;
                    case 'B':
                        outString += ("-... ");
                        break;
                    case 'C':
                        outString += ("-.-. ");
                        break;
                    case 'D':
                        outString += ("-.. ");
                        break;
                    case 'E':
                        outString += (". ");
                        break;
                    case 'F':
                        outString += ("..-. ");
                        break;
                    case 'G':
                        outString += ("--. ");
                        break;
                    case 'H':
                        outString += (".... ");
                        break;
                    case 'I':
                        outString += (".. ");
                        break;
                    case 'J':
                        outString += (".--- ");
                        break;
                    case 'K':
                        outString += ("-.- " );
                        break;
                    case 'L':
                        outString += (".-.. ");
                        break;
                    case 'M':
                        outString += ("-- ");
                        break;
                    case 'N':
                        outString += ("-. ");
                        break;
                    case 'O':
                        outString += ("--- ");
                        break;
                    case 'p':
                        outString += (".--. ");
                        break;
                    case 'Q':
                        outString += ("--.- ");
                        break;
                    case 'R':
                        outString += (".-. ");
                        break;
                    case 'S':
                        outString += ("... ");
                        break;
                    case 'T':
                        outString += ("- ");
                        break;
                    case 'U':
                        outString += ("..- ");
                        break;
                    case 'V':
                        outString += ("...- ");
                        break;
                    case 'W':
                        outString += (".-- ");
                        break;
                    case 'X':
                        outString += ("-..- ");
                        break;
                    case 'Y':
                        outString += ("-.-- ");
                        break;
                    case 'Z':
                        outString += ("--.. ");
                        break;
                    case ' ':
                        outString += (" ");
                        break;
                    case '1':
                        outString += (".---- ");
                        break;
                    case '2':
                        outString += ("..--- ");
                        break;
                    case '3':
                        outString += ("...-- ");
                        break;
                    case '4':
                        outString += ("....- ");
                        break;
                    case '5':
                        outString += ("..... ");
                        break;
                    case '6':
                        outString += ("-.... ");
                        break;
                    case '7':
                        outString += ("--... ");
                        break;
                    case '8':
                        outString += ("----. ");
                        break;
                    case '9':
                        outString += ("----. ");
                        break;
                    case '0':
                        outString += ("----. ");
                        break;
                    case '.':
                        outString += (" ");
                        break;

                        
                }
            }
            Console.WriteLine(message + " in morse code is ");
            Console.WriteLine(outString);

        }
    }
}
