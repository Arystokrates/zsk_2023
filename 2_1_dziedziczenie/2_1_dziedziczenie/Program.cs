namespace _2_1_dziedziczenie
{
    internal class Program
    {
        class Address(string city, string street, string houseNumber, string postalCode)
        {
            public string City { get; set; } = city;
            public string Street { get; set; } = street;
            public string HouseNumber { get; set; } = houseNumber;
            public string PostalCode { get; set; } = postalCode;
        }
        class Person(string firstName, string surname, DateTime dateOfBirth, Address address)
        {
            public string FirstName { get; set; } = firstName;
            public string Surname { get; set; } = surname;
            public DateTime DateOfBirth { get; set; } = dateOfBirth;
            public Address Address { get; set; } = address;
            public byte Age 
            { 
                get 
                { 
                    TimeSpan diff = DateTime.Now - DateOfBirth;
                    return (byte)(diff.Days / 365.25);
                }
            }

            public string GetFullName()
            {

                return $"{FirstName} {Surname}, lat {Age}";
            }
        }
        class Student(string name, string surname, DateTime dateOfBirth, Address address, string studentNumber) : Person(name, surname, dateOfBirth, address)
        {
            public string StudentNumber { get; set; } = studentNumber;
        }
        class Teacher : Person
        {
            public List<string> subjects = [];

            public Teacher(string name, string surname, DateTime dateOfBirth, Address address, List<string> Subjects) : base(name, surname, dateOfBirth, address)
            {
                subjects = Subjects;
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new("Maja", "Pawełek", new DateTime(2000, 12, 2), new Address("Poznań", "Połączenia", "12", "63-004"));
            Console.WriteLine($"{p1.GetFullName()}, adres: {p1.Address.City}");

            Student s1 = new("Gabriela", "Mokarczyk", new DateTime(2007, 5, 23), new Address("Biedrusko", "Zjednoczenia", "2137", "62-003"), "12");
            Console.WriteLine($"{s1.GetFullName()}, miejscowość, {s1.Address.City}");

            Teacher t1 = new("Maria", "Stankiewicz", new DateTime(1960, 3, 12), new Address("Łęczyca", "Cypriana Karola Norwida", "5", "72-335"), ["matematyka", "informatyka"]);
            Console.WriteLine($"{t1.GetFullName()}, miejscowość, {t1.Address.City}, przedmioty: {t1.subjects[0]}, {t1.subjects[1]}");

            Console.ReadKey();
        }
    }
}
//Dziedziczenie – zadanie 1
// Napisz program w języku C#, który ilustruje pojęcia programowania obiektowego,
//takie jak klasy, dziedziczenie, właściwości i metody.
// Zdefiniuj klasę bazową Person, która ma pola name, surname i dateOfBirth oraz
//konstruktor przyjmujący te wartości jako parametry.
// Dodaj do klasy Person metodę GetFullName, która zwraca pełne imię i nazwisko
//osoby, oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
// Zdefiniuj klasę Address, która ma pola city, street, houseNumber i postalCode jako
//właściwości oraz konstruktor przyjmujący te wartości jako parametry.
// Dodaj do klasy Person pole address typu Address i zmodyfikuj konstruktor klasy
//Person, aby przyjmował obiekt klasy Address jako parametr.
// Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe
//pole studentNumber oraz konstruktor przyjmujący te wartości jako parametry.
// Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe
//pole subjects typu List<string> oraz konstruktor przyjmujący te wartości jako
//parametry.
// Utwórz obiekty każdej klasy, używając słowa kluczowego new i podając odpowiednie
//wartości w konstruktorach.
// Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
//właściwości obiektów.
