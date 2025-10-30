using System.Text.Json;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var utente = new Utente { Nome = "Giovanni", Eta = 29 };

            string js = JsonSerializer.Serialize(utente);
            Console.WriteLine("Questo è il serializer " + js);
            string utjs = @"C:\Users\Laboratorio12\Desktop\Esercizi_C#\utente.json";

            try
            {
                File.WriteAllText(utjs, js);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                var text = File.ReadAllText(utjs);
                Utente des = JsonSerializer.Deserialize<Utente>(text);
                string nome = des.Nome;
                int eta = des.Eta;
                //var utente1 = new Utente { Nome=nome, Eta=eta };
                Console.WriteLine($"Nome: {nome} Età: {eta}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
