﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cykly.CyklusWhile();
            //Cykly.DoWhile();
            //Cykly.CyklusFor();
            //Cykly.CyklusForContinue();
            //Cykly.HodnotVsReferencie();



            // Auto autoPovodne = new Auto();
            //autoPovodne.Farba = "cervena";

            //Cykly.PrefarbiAuto(autoPovodne);
            //Console.WriteLine(autoPovodne.Farba);

            //int aPovodne = 10;
            //Cykly.ZvysOJEdnicku(ref aPovodne); // ref odovzdava referencny typ nie hodnotovy !!! 
            //Console.WriteLine(aPovodne);

            Pole p = new Pole();
            //p.VypisPole();
            p.VypisPole();


            Console.ReadLine();
        }
    }
}
