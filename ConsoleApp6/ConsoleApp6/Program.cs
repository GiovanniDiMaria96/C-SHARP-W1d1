using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Action NoParametri = () => { Console.WriteLine("Ciao Mondo"); };
            NoParametri();

            Action<string> Func = (nome) => { Console.WriteLine("Benvenuto " + nome); };
            Func("Giovanni");

            Action<int, int> Somma = (a, b) => { Console.WriteLine(a + b); };
            Somma(2, 6);

            Action<List<string>> Iterazione = (lista) =>
            {

                Console.WriteLine(string.Join(",", lista).ToUpper());
            };

            var lista = new List<string> { "giovanni", "francesco", "giuseppe" };
            Iterazione(lista);


            Action<string> stampa = messaggio => Console.WriteLine(messaggio);
            EseguiOperazioneSicura("...Lavoro in corso...", stampa);
        }

        public static void EseguiOperazioneSicura(string x, Action<string> y)
        {

            Console.WriteLine("Inizio operazione");

            try
            {
                y(x);
                Console.WriteLine("Fine operazione");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
                throw;
            }

        }


    }
}
