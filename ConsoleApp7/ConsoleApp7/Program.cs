using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            Func<int> NumeroCasuale = () =>
            {
                return a.Next();
            };
            Console.WriteLine(NumeroCasuale());


            Func<int, int> Quadrato = (a) =>
            {
                return a * a;
            };
            Console.WriteLine(Quadrato(3));


            Func<string, string, string> NomeCognome = (c, d) =>
            {
                string e = c + d;
                return e;
            };
            Console.WriteLine(NomeCognome("Giovanni", "Di Maria"));

            /////////////////////////////

            Predicate<int> numero = (a) =>
            {
                if (a % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine(numero(5));
            Console.WriteLine(numero(4));


            Predicate<string> stringa = (b) =>
            {
                if (!string.IsNullOrEmpty(b))
                {
                    return true;
                }
                else
                {
                    { return false; }
                }
            };
            Console.WriteLine(stringa("Gio"));
            Console.WriteLine(stringa(null));
            Console.WriteLine(stringa(""));
        }
    }
}
