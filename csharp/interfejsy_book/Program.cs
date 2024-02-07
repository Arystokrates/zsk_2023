using System;
using Classes;

namespace interfejsy_bucher
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Book> books =
            [
                new Book("Kotek", "Marian Langiewicz", 1863, 21.37),
                new Book("Piesek", "Mariusz Mychlik", 1992, 37.21),
                new Book("Jak zostałam futrzakiem", "Nela Palinkiewicz", 2030, 21.37)
            ];

            Console.WriteLine("Lista ksiazek");
            int i = 0;
			foreach (Book book in books)
			{
                i+=1;
				Console.WriteLine("Książka nr" + i + ": " + book);
			}
            books.Sort();
            Console.WriteLine("\nPosortowane wg ceny: ");
            foreach (Book book in books)
            {
                Console.WriteLine(books);
            }
            Console.WriteLine("\nWedlug daty publikacji: ");
            var sortedByYear = books.OrderBy(book => book.YearOfPublication);
            foreach (Book book in sortedByYear)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\nOd najmlodszej do najstarszej ");
            var sortedByDescYear = books.OrderByDescending(book => book.YearOfPublication);
            foreach (Book book in sortedByYear)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\nOd najmlodszej do najstarszej ");
            var sortedByAuthor = books.OrderBy(book => book.Author);
            foreach (Book book in sortedByAuthor)
            {
                Console.WriteLine(book);
            }

            System.Console.WriteLine("\n Sortowanie książek według ceny nierosnąco, a następnie według roku publikacji od najstarszej do najmłodszej książki");
            var sortedByPriceDescAndSecondlyByAgeAsc = 
                books
                    .OrderByDescending(b => b.Price)
                    .ThenBy(b => b.YearOfPublication)
                    ;
            foreach (Book book in sortedByPriceDescAndSecondlyByAgeAsc)
            {
                System.Console.WriteLine(book);
            }
            Console.ReadKey();
		}
	}
}
// Interfejsy
//  Zdefiniuj klasę Book, która ma reprezentować informacje o książce, takie jak tytuł,
// autor, rok wydania i cena.
//  Zaimplementuj interfejs IComparable<Book> w klasie Book, który pozwala na
// porównywanie obiektów typu Book według ich ceny. Aby to zrobić, zdefiniuj metodę
// CompareTo(Book other), która zwraca liczbę całkowitą oznaczającą relację pomiędzy
// bieżącym obiektem a innym obiektem typu Book.
//  Zdefiniuj konstruktor klasy Book, który przyjmuje jako parametry tytuł, autora, rok
// wydania i cenę książki i inicjalizuje odpowiednie pola klasy.
//  Zdefiniuj metodę ToString() klasy Book, która zwraca reprezentację tekstową obiektu
// typu Book, składającą się z tytułu, autora, roku wydania i ceny książki, oddzielonych
// przecinkami.
//  Zdefiniuj klasę Program, która zawiera metodę Main, w której utwórz listę książek
// typu Book i dodaj do niej kilka przykładowych obiektów.
//  Posortuj listę książek według ceny, używając metody Sort klasy List<T>. Wyświetl
// posortowaną listę na konsoli, używając metody ToString() klasy Book.
//  Posortuj listę książek według innych kryteriów, np.daty publikacji, autora, tytułu,
// używając metod OrderBy, OrderByDescending i ThenBy z przestrzeni nazw
// Linq.Wyświetl posortowane listy na konsoli, używając metody ToString() klasy
// Book.


