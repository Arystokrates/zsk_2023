

namespace _5_eventy
{
    public delegate void MessageHandler(string message, string publisherName);
    public class Publisher(string name)
    {
        public event MessageHandler? MessageEvent = null;

        public void SendMessage(string message)
        {
            if (MessageEvent is not null)
            {
                MessageEvent(message, name);
            }
        }
    }
    public class Subscriber(string name)
    {
        public void OnMessageReceived(string message, string publisherName)
        {
            Console.WriteLine(name + " dostal wiadomosc od opublikatora " + publisherName + ": " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var opublikator = new Publisher("pyssa");
            var subskryba = new Subscriber("nela");
            var subskryba2 = new Subscriber("maja");

            opublikator.MessageEvent += subskryba.OnMessageReceived;
            opublikator.MessageEvent += subskryba2.OnMessageReceived;
            opublikator.SendMessage("Zmiana ubioru żeńskiego stroju szkolnego");
        }
    }
}
/*
 * Zdefiniuj delegat MessageHandler, który przyjmuje string i zwraca void.
o Zdefiniuj klasę a z polem MessageEvent typu MessageHandler,
zadeklarowanym jako event.
o Zdefiniuj metodę SendMessage w klasie Publisher, która przyjmuje string i zwraca
void. Metoda ta ma wywoływać zdarzenie MessageEvent, jeśli ma subskrybentów.
*/

/*
 * Zdefiniuj klasę Subscriber z metodą OnMessageReceived, która przyjmuje string i
zwraca void. Metoda ta ma wypisywać na konsolę wiadomość otrzymaną od
wydawcy.
o Zdefiniuj klasę Program z metodą Main, która jest punktem wejścia programu.
o W metodzie Main utwórz obiekty klasy Publisher i klasy Subscriber.
o Zasubskrybuj zdarzenie MessageEvent za pomocą metody OnMessageReceived.
o Wywołaj metodę SendMessage kilka razy z różnymi parametrami i sprawdź, czy
subskrybent otrzymuje wiadomości.
o Anuluj subskrypcję zdarzenia i wywołaj metodę SendMessage ponownie. Sprawdź,
czy subskrybent nadal otrzymuje wiadomości
*/