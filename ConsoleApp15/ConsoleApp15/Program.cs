using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Contatore contatore = new Contatore();

            Task task1 = Task.Run(() => contatore.Incrementa());
            Task task2 = Task.Run(() => contatore.Incrementa()); //QUESTO DIMOSTRA COME DUE TASK NON FUNZIONANO COME DOVREBBERO
                                                                 // PER ESEMPIO IN UN CONTEGGIO
            await Task.WhenAll(task1, task2);
            Console.WriteLine(contatore.conteggio);
        }
    }
}
