namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Task t = Task.Run(() => class1.Stampa());
            Console.WriteLine("Inizio");
            t.Wait();
            Console.WriteLine("Fine");

        }
    }
}
