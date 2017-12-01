using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnivtyzdni
{
    class DniVTyzdni
    {
        public static void VypisDenTyzdna(string cisloDna)
        {
            int denTyzdna = int.Parse(cisloDna);
            if (SkontrolujVstup(denTyzdna))
                switch (denTyzdna)
            {
                case 0:
                case 7:
                    Console.WriteLine("nedela");
                    break;
                case 1:
                    Console.WriteLine("pondelok");
                    break;

                case 2:
                    Console.WriteLine("utorok");
                    break;
                case 3:
                    Console.WriteLine("streda");
                    break;

                case 4:
                    Console.WriteLine("stvrtok");
                    break;

                case 5:
                    Console.WriteLine("piatok");
                    break;
                case 6:
                    Console.WriteLine("sobota");
                    break;

                default:
                    Console.WriteLine("Nespravna hodnota");
                    break;
            }
            
            else
            {
                Console.WriteLine("spatny vstup");
            }


        }
        public static void VypisDenTyzdna(string cisloDna, bool nedelaJePrva)
        {

            int denTyzdna = int.Parse(cisloDna);
            if (SkontrolujVstup(denTyzdna))
            {
                if (nedelaJePrva)
                {
                    denTyzdna--;

                }
                VypisDenTyzdna(denTyzdna.ToString());
            }
            else
            {
                Console.WriteLine("spatny vstup");

            }
            

        }
        public static bool SkontrolujVstup(int cisloDna)
        {
            return (cisloDna >= 1 && cisloDna <= 7);

        }

    }
}
