using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var class1 = new Class1();
            var task = class1.BottonePremuto_Click();



            while (!task.IsCompleted)
            {   
                Console.WriteLine(".");
                await Task.Delay(500);
            }
        }
    }
}
