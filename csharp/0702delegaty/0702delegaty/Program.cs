using System;

namespace _0702delegaty
{
    internal class Program
    {
        public delegate int Operation(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y) => x * y;
        public static int Divide(int x, int y) => x / y;
        public static void DisplayResult(Operation op, int x, int y)
        {
            int result;
            if (op.Method.Name == "Divide" && y == 0) Console.WriteLine("Dzielenie przez zero!");
            else
            {
                result = op(x, y);
                Console.WriteLine($"Wynik operacji {op.Method.Name} na liczbach {x} i {y} = {result}");
            }
        }
        public static int GetIntFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            int number;
            string? input;
            bool isValid;
            do
            {
                input = Console.ReadLine();
                isValid = int.TryParse(input, out number) && number >= 0;
                if (!isValid) Console.WriteLine("Nieprawidłowe dane. Podaj liczbę całkowitą nieujemną");
            }
            while (!isValid);
            return number;
        }
        static void Main(string[] args)
        {
            int a = GetIntFromUser("Podaj a: ");
            int b = GetIntFromUser("Podaj b: ");
            Operation addition = new Operation(Add);
            Operation substraction = new Operation(Substract);
            Operation multiplication = new Operation(Multiply);
            Operation division = new Operation(Divide);
            DisplayResult(addition, a, b);
            DisplayResult(substraction, a, b);
            DisplayResult(multiplication, a, b);
            DisplayResult(division, a, b);
        }
    }
}
/*
Zadania - delegaty
● Napisz program w języku C#, który używa delegatów do wykonania
operacji arytmetycznych na dwóch liczbach podanych przez
użytkownika.

● Zadeklaruj typ delegata, który przyjmuje i zwraca int, i nazwij go
Operation.

● Zdefiniuj cztery metody statyczne, które realizują operacje dodawania,
odejmowania, mnożenia i dzielenia dwóch liczb, i nazwij je odpowiednio
Add, Subtract, Multiply i Divide.

● Zdefiniuj metodę statyczną, która wyświetla wynik operacji na liczbach, i
nazwij ją DisplayResult. Metoda ta powinna przyjmować jako argumenty
instancję delegata Operation, dwie liczby i wywoływać metodę związaną
z delegatem na tych liczbach. Metoda ta powinna również obsługiwać
wyjątek DivideByZeroException, jeśli wystąpi, i wyświetlać odpowiedni
komunikat o błędzie.

● Zdefiniuj funkcję, która pobiera liczbę całkowitą nieujemną od
użytkownika, i nazwij ją GetIntFromUser. Funkcja ta powinna wyświetlać
podpowiedź dla użytkownika, pobierać dane od użytkownika,
sprawdzać, czy dane są poprawne i nieujemne, i zwracać liczbę. Jeśli
dane są nieprawidłowe, funkcja powinna wyświetlać komunikat o
błędzie i prosić użytkownika o ponowne wprowadzenie danych.

● W metodzie Main, pobierz dwie liczby od użytkownika za pomocą
funkcji GetIntFromUser i zapisz je w zmiennych a i b.

● Utwórz cztery instancje delegata Operation i przypisz im metody Add,
Subtract, Multiply i Divide.

● Wywołaj metodę DisplayResult dla każdej instancji delegata i przekaż jej
zmienne a i b jako argumenty.

● Przetestuj swój program dla różnych danych wejściowych i sprawdź, czy
działa poprawnie.
*/