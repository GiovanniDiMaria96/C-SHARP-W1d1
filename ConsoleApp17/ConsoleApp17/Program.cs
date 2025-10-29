    using System.Text;

    namespace ConsoleApp17
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string path = @"C:\Users\Laboratorio12\Desktop\Esercizi_C#\saluto.txt";

                try
                {

                    File.WriteAllText(path, "Ciao mondo!");
                    Console.WriteLine("saluto.txt creato");
                    

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            
            }

        }
    }

