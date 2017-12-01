using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class Cykly // 3 zakladne cykly
    {
        public static void CyklusWhile()
        {
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine("Ahoj");
                i++;

            }
        }
        public static void DoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine("{0}",i);
                i++;
            }
            while (i < 5);
        }
        public static void CyklusFor(int opakovanie)
        {
            //for (int i = 0; i < 10; i+=2) jedna vnutorna premenna
            //for (int i = 0, j = 10; i<= j; i++,j--) dve...


            for (int i = 0; i < opakovanie; i++)

            {
                opakovanie = 10;
                // Console.WriteLine(i);
                //Console.WriteLine(i);
                //Console.WriteLine("dvojice{0},{1}", i, j);
            }

        }
       
        
        public static void CyklusForContinue()

                {
                    for (int i = 0; i < 10; i++)
                    {
                        int zbytok = i % 2;
                        if (zbytok != 0)
                        {

                            continue;
                        }

                        Console.WriteLine(i);

                    }

                }
        
    }
    
}

