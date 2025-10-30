using System.Text.Json;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var utente = new Utente { Nome = "Giovanni", Eta = 29 };

            string js = JsonSerializer.Serialize(utente);
            Console.WriteLine(js);
            string utjs = @"C:\Users\Laboratorio12\Desktop\Esercizi_C#\utente.json";

            try
            {
                File.WriteAllText(utjs, js);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
