using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Avvia download");
            // await Task.Run(() => class1.SimulaDownloadAsync());
            var x = await class1.SimulaDownloadAsync();
            Console.WriteLine(x);
        }
    }
}
