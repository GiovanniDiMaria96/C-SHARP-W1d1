using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Class1 class1 = new Class1();

            await Task.Run(() => class1.Esegui());
        }
    }
}
