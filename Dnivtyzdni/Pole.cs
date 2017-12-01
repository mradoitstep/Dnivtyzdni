using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class Pole
    {
        public int[] VnutornePole = new int[4] { 10, 5, 2, 4 };  // pole je referencny typ, inicializuje sa = [velkost]{hodnoty};
        public void VypisPole()
        {
            //VnutornePole.Length - takto sa zadava dlzka
            //VnutornePole[2] 
            for (int i = 0; i < VnutornePole.Length; i++)
            {
                Console.WriteLine(VnutornePole[i]);

            }
            
        }
        public void NapisPole()
        {
            Random r = new Random();

            for (int i = 0; i < VnutornePole.Length; i++)
            {
                VnutornePole[i] = new Random().Next(100);
            }

        }
    }
}
