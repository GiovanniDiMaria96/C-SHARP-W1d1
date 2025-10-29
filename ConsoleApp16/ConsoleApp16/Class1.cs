using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Class1
    {
        public async Task BottonePremuto_Click()
        {
            Console.WriteLine("Operazione avviata...");
            var x = await OperazioneLungaAsync();
            Console.WriteLine( x.ToString() );


        }

        public async Task<string> OperazioneLungaAsync()
        {
            await Task.Delay(3000);
            var x = "Risultato pronto";
            return x;
        }
    }
}
