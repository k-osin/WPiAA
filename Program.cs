using WPiAA.Builder;
using WPiAA.Facade;
using WPiAA.Factory;
using WPiAA.Singleton;

namespace WPiAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////
            
            var singletonVault = WPiAA.Singleton.Vault.GetInstance();
            string key = singletonVault.RetrieveAccessKey();
            
            Console.WriteLine("Klucz dostępu z Azure: " + key);
            
            string secondKey = singletonVault.RetrieveAccessKey();
            string thirdKey = singletonVault.RetrieveAccessKey();

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////

            WPiAA.Factory.Garnizon garnizon = new WPiAA.Factory.Garnizon();
            Wojownik[] wojownicy = new Wojownik[10];

            wojownicy[0] = garnizon.SzkolWojownika("Piechur");
            wojownicy[1] = garnizon.SzkolWojownika("Piechur");
            wojownicy[2] = garnizon.SzkolWojownika("Piechur");

            wojownicy[3] = garnizon.SzkolWojownika("Konny");
            wojownicy[4] = garnizon.SzkolWojownika("Konny");
            wojownicy[5] = garnizon.SzkolWojownika("Konny");

            wojownicy[6] = garnizon.SzkolWojownika("Strzelec");
            wojownicy[7] = garnizon.SzkolWojownika("Strzelec");
            wojownicy[8] = garnizon.SzkolWojownika("Strzelec");
            wojownicy[9] = garnizon.SzkolWojownika("Strzelec");

            foreach (var wojownik in wojownicy)
            {
                wojownik.Walcz();
            }

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////

            WPiAA.Builder.Garnizon garnizon2 = new WPiAA.Builder.Garnizon();

            // Szkolenie 2 Piechurów
            PiechurBuilder piechurBuilder = new PiechurBuilder();
            garnizon2.SetBuilder(piechurBuilder);
            garnizon2.Szkolenie();
            Wojownik piechur1 = garnizon2.GetWojownik();
            garnizon2.Szkolenie();
            Wojownik piechur2 = garnizon2.GetWojownik();

            // Szkolenie 2 Konncyh
            KonnyBuilder konnyBuilder = new KonnyBuilder();
            garnizon2.SetBuilder(konnyBuilder);
            garnizon2.Szkolenie();
            Wojownik konny1 = garnizon2.GetWojownik();
            garnizon2.Szkolenie();
            Wojownik konny2 = garnizon2.GetWojownik();

            // Szkolenie 2 Strzelców
            StrzelecBuilder strzelecBuilder = new StrzelecBuilder();
            garnizon2.SetBuilder(strzelecBuilder);
            garnizon2.Szkolenie();
            Wojownik strzelec1 = garnizon2.GetWojownik();
            garnizon2.Szkolenie();
            Wojownik strzelec2 = garnizon2.GetWojownik();

            // Wojownicy walczą
            piechur1.Walcz();
            piechur2.Walcz();
            konny1.Walcz();
            konny2.Walcz();
            strzelec1.Walcz();
            strzelec2.Walcz();

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////



            ////////////////////////////////////////////////////////

            Prototype.Ork ork = new Prototype.Ork();
            ork.CreateAndShowOrk();

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////



            ////////////////////////////////////////////////////////

            const string apiKey = "API-KEY";
            Weather weatherService = new Weather(apiKey);
            weatherService.GetWeatherFrom("Warsaw").GetAwaiter().GetResult();

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////
        }
    }
}