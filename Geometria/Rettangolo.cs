using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        //dichiarazione attributi

        public int baseRettangolo;
        public int altezzaRettangolo;
        public int area;
        public int perimetro;
        //costruttore

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {                
                this.baseRettangolo = baseRettangolo;
                this.altezzaRettangolo = altezzaRettangolo;            
        }

        
        
        
        
        //metodi

        public void CalcolaArea() //avrei potuto passare i parametri nella funzione mettendo tra parentesi: (int baseRettangolo, int altezzaRettangolo)
        {
            
            area = baseRettangolo * altezzaRettangolo;
            
        }

        public void CalcolaPerimetro()
        {
            
            perimetro = (baseRettangolo * 2) + (altezzaRettangolo * 2);
            
        }



        public void DisegnaRettangolo()
        {
            /*
            int latoOrizzontale;
            int latoVerticale;
            string spazioInterno = "  ";
            */

            string latoOrizzontale = "--";
            string latoVerticale = "|";
            string spazioInterno = "--";

            for (int i = 0; i < altezzaRettangolo; i++)
            {
                for(int j = 0; j < baseRettangolo; j++)
                {

                    //latoOrizzontale = j;
                    //latoVerticale = i;

                    
                    if ((i== 0 || i == altezzaRettangolo-1) && (j==0 || j == baseRettangolo -1))
                    {
                        Console.Write("*");
                    }else if ((i == 0) || ( i == altezzaRettangolo-1))
                    {
                        Console.Write(latoOrizzontale);
                    }
                    else if ((j == baseRettangolo -1) || (j == 0))
                    {
                       Console.Write(latoVerticale);
                    }else Console.Write(spazioInterno);//spazi interni
                   
                    if( j == baseRettangolo -1) { Console.WriteLine(""); }//va a capo


                }
            }
        }
    }
}
