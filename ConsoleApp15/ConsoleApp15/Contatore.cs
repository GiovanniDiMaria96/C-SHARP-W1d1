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
            //USO DEL LOCK
        //internal class Contatore
    //{
    //    public int conteggio = 0;
    //    public object lockobject = new object();

    //    public int Incrementa()
    //    {
    //        for (int i = 0; i < 100000; i++)
    //        {
    //            lock (lockobject) { conteggio++; }
    //        }
    //        return conteggio;

    //    }
    //}
}

