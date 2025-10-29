using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Class1
    {

        public void Stampa()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }

    }
}
