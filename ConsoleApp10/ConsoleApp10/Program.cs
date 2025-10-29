namespace ConsoleApp10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Thread t = new Thread(class1.Stampa);
            t.Start();
            Console.WriteLine("Thread principale in esecuzione");
            t.Join();
            Console.WriteLine("Thread secondario terminato.");
        }
    }
}
