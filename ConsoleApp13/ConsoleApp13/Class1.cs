using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Class1
    {
       public async Task<string>  SimulaDownloadAsync()
        {
            Console.WriteLine("Download iniziato...");
            await Task.Delay(2000);
            return "Download completato";


        }
    }
}
