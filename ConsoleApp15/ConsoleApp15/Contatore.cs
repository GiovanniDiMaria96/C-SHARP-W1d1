using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    
    internal class Contatore
    {
        public int conteggio = 0;
        
        public int Incrementa()
        {
            for (int i = 0; i < 100000; i++)
            {
                conteggio++;
            }
            return conteggio;

        }
    }
}
