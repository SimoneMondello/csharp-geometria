using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangoli
{
    internal class Ilmiorettangolo
    {
        // ATTRIBUTI del vostro rettangolo. 
        // private perchè così i metodi e il costruttore si occupano
        // di verificare che il vostro oggetto stia sempre BENE!
        private int baseRettangolo;
        private int altezzaRettangolo;
        private int area;
        private int perimetro;




        // Costruttore intero con tutti i parametri
        public Ilmiorettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;

            
        }

        //Metodo che si occupa di STAMPARE il rettangolo 
        public void stamparettangolo()
        {
            Console.WriteLine("----- rettangolo -------");
            Console.WriteLine("base: " + baseRettangolo + "cm");
            Console.WriteLine("altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Area: " + CalcolaArea() + "cm");
            Console.WriteLine("Perimetro: " + calcoloperimetro() + "cm");
            Console.WriteLine("------------------");

        }
        //--------------------------------------------
        public int  CalcolaArea()
        {
            area= altezzaRettangolo*baseRettangolo;
            return area;
            
        }

        public int calcoloperimetro()
        {
            perimetro = 2 * (altezzaRettangolo + baseRettangolo);
            return perimetro;
        }
        //-------------------------
        public void Stamparerettangolouno()
        {
            baseRettangolo = 40;
            altezzaRettangolo = 30;
            Console.WriteLine("----- rettangolo 1 -------");
            Console.WriteLine("base: " + baseRettangolo + "cm");
            Console.WriteLine("altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Area: " + CalcolaArea() + "cm");
            Console.WriteLine("Perimetro: " + calcoloperimetro() + "cm");
            Console.WriteLine("------------------");

        }

    }   


    
            
}

