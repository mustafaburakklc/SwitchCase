using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

           /* switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayindayiz.");
                    break;
                case 2:
                    Console.WriteLine("Subat ayindayiz.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayindayiz.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayindayiz.");
                    break;
                case 5:
                    Console.WriteLine("Mayis ayindayiz.");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayindayiz.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayindayiz.");
                    break;
                case 8:
                    Console.WriteLine("Agustos ayindayiz.");
                    break;
                case 9:
                    Console.WriteLine("Eylul ayindayiz.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayindayiz.");
                    break;
                case 11:
                    Console.WriteLine("Kasim ayindayiz.");
                    break;
                case 12:
                    Console.WriteLine("Aralik ayindayiz.");
                    break;
                default:
                    break;
        }*/
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        System.Console.WriteLine("Kis aylarindayiz.");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        System.Console.WriteLine("Ilkbahar aylarindayiz.");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        System.Console.WriteLine("Yaz aylarindayiz.");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        System.Console.WriteLine("Sonbahar aylarindayiz.");
                        break;
                    default:
                    break;
                }
        }
        
    }
}
