using System;
using System.Collections.Generic;
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



    }
}
