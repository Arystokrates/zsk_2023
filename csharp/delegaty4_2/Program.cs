using System.Threading.Channels;

namespace delegaty4_2
{
    delegate bool Logic(bool a, bool b);
    internal class Program
    {
        static bool And(bool a, bool b)
        {
            return a && b;
        }
        static bool Or(bool a, bool b)
        {
            return a || b;
        }
        static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }
        static bool Not(bool a, bool b)
        {
            return !a;
        }
        static void DisplayResult(Logic logic, bool a, bool b)
        {
            try
            {
                bool result = logic(a, b);
                Console.WriteLine($"Rezultat: a = {a}, b = {b} -> result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static bool GetBoolFromUser()
        {
            while (true)
            {
                Console.WriteLine("Wprowadz true or false: ");
                string input = Console.ReadLine();
                bool value;
                if (bool.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Podaj prawidlowa wartosc (wpisz true of false)");
                }
            }
        }

        static void Main(string[] args)
        {
            bool x = GetBoolFromUser();
            bool y = GetBoolFromUser();

            Logic and = new Logic(And);
            Logic or = new Logic(Or);
            Logic xor = new Logic(Xor);
            Logic not = new Logic(Not);

            System.Console.WriteLine("And: ");
            DisplayResult(and, x, y);
            System.Console.WriteLine("Or: ");
            DisplayResult(or, x, y);
            System.Console.WriteLine("Xor: ");
            DisplayResult(xor, x, y);
            System.Console.WriteLine("Not: ");
            DisplayResult(not, x, y);
        }
    }
}
