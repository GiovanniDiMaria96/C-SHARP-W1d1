ace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Task t = Task.Run(() => class1.Stampa());
            Console.WriteLine("Thread principale in esecuzione");

            t.Wait();
            Console.WriteLine("Thread secondario terminato");
        }
    }
}
