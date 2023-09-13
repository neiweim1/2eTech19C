using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{ /*Wzór fasady (pisany także jako fasada ) to wzorzec projektowania oprogramowania powszechnie stosowany w programowaniu obiektowym . 
Analogicznie do fasady w architekturze, fasada jest obiektem , który służy jako skierowany do przodu interfejs maskujący bardziej złożony kod podstawowy lub strukturalny. 
Fasada może:
poprawić czytelność i użyteczność biblioteki oprogramowania poprzez maskowanie interakcji z bardziej złożonymi komponentami za pojedynczym (i często uproszczonym) interfejsem API
zapewnić kontekstowy interfejs do bardziej ogólnej funkcjonalności (wraz z kontekstową walidacją danych wejściowych )
służyć jako punkt wyjścia dla szerszego refaktoryzacji systemów monolitycznych lub ściśle powiązanych na rzecz bardziej luźno powiązanego kodu
Deweloperzy często używają wzorca projektowego fasady, gdy system jest bardzo złożony lub trudny do zrozumienia, ponieważ system ma wiele współzależnych klas lub ponieważ jego kod źródłowy jest niedostępny. Ten wzorzec ukrywa złożoność większego systemu i zapewnia prostszy interfejs dla klienta. Zwykle obejmuje pojedynczą klasę opakowania zawierającą zestaw elementów wymaganych przez klienta. Członkowie ci uzyskują dostęp do systemu w imieniu klienta fasady i ukrywają szczegóły implementacji.

Użycie Fasady można stwierdzić po 
istnieniu klasy o uproszczonym interfejsie, która deleguje większość 
swoich zadań innym klasom. Zazwyczaj fasady zarządzają całym cyklem 
życia używanych przez siebie obiektów.

Wzorzec Fasada jest często używany w aplikacjach pisanych w C#, gdzie przydaje się w pracy ze złożonymi bibliotekami i API.


Fasada (ang. facade) - wzorzec projektowy, który dostarcza uproszczony interfejs obsługi biblioteki lub określonego zbioru klas.
Fasada nie ogranicza funkcjonalności - dostarcza wygodniejszy interfejs do zarządzania określoną częścią kodu.

zastosowanie:
zwiększenie czytelności kodu poprzez wprowadzenie uproszczonego interfejsu do jego obsługi;
zmniejszenie zależności pomiędzy plikami źródłowymi, co prowadzi do większej elastyczności w rozwoju projektu;
uproszczenie zbioru źle zaprojektowanych interfejsów, jednym dobrze zaprojektowanym interfejsem.

Przykładem użycia wzorca fasady może być aplikacja bankomatowa, która musi wchodzić w interakcję z systemem bankowym. 
Skoro aplikacja bankomatowa wykorzystuje tylko niewielką część możliwości systemu bankowego 
(autoryzacja karty, sprawdzenie stanu konta, wypłata i ew. wpłata), to można zastosować obiekt fasady, 
który zasłoni przed zewnętrznymi aplikacjami skomplikowaną strukturę wewnętrzną systemu bankowego. Upraszcza to pisanie aplikacji na bankomaty,
 a jednocześnie zapewnia lepsze bezpieczeństwo systemu bankowego.


1. Wzorce kreacyjne
• Singleton
• Fabryka
• Prototyp
• Budowniczy

2. Wzorce strukturalne
• Adapter
• Fasada
• Dekorator
• Płatek śniegu
• Proxy

Wzorce czynnościowe
• Szablon metody
• Strategia
• Komenda
• Memento
• Stan
• Interpreter
• Iterator
• Łańcuch odpowiedzialności
• Obserwator
*/

    //fasada strukturalna
    //wzorzec projektowy
    //asocjacja xwy
    class LoginAvailable
    {
        public void LoginCheck()
        {
            Console.WriteLine("login dostepny");
        } 
    }

    class Database
    {
        public static void insert()
        {
            Console.WriteLine("dodano usera");
        }
    }

    internal class User //mini fasadka?? XDDD w skrócie dodawnie z innych klas metod żeby nie pisać tysiąc razy trgo samego
    {
        public static void registerUser()
        { 
            LoginAvailable log = new LoginAvailable();
            log.LoginCheck();
            Database.insert();
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User.registerUser();
        }
    }
}
