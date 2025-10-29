using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Class1
    {
        public async Task DownloadFile1Async()
        {
            Console.WriteLine("Inizio download 2 sec.");
            await Task.Delay(2000);
            Console.WriteLine("Fine download 2 sec.");
        }
    
        public async Task DownloadFile2Async()
        {
            Console.WriteLine("Inizio download 3 sec.");
            await Task.Delay(3000);
            Console.WriteLine("Fine download 3 sec.");

        }

        public async Task Esegui()
        {
            Task t1 = DownloadFile1Async();
            Task t2 = DownloadFile2Async();

            await Task.WhenAll(t1, t2);
        }

    }
}
