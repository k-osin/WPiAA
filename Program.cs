﻿using WPiAA.Adapter;
using WPiAA.Bridge;
using WPiAA.Builder;
using WPiAA.Composite;
using WPiAA.Decorator;
using WPiAA.Facade;
using WPiAA.Factory;
using WPiAA.Flyweight;
using WPiAA.Proxy;
using WPiAA.Singleton;
using OperatingSystem = WPiAA.Bridge.OperatingSystem;

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




            //////////////////////////////////////////////////////// PROXY

            IFile publicFile = new PublicFile();
            IFile restrictedFile = new FileProxy("1234");
            bool endLoop = false;

            while (true)
            {
                if (endLoop)
                {
                    break;
                }

                Console.WriteLine("\nWybierz plik do pobrania:");
                Console.WriteLine("1. Plik publiczny");
                Console.WriteLine("2. Plik zastrzeżony");
                Console.WriteLine("0. Wyjście");

                Console.Write("Twój wybór: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        publicFile.Access();
                        break;
                    case "2":
                        restrictedFile.Access();
                        break;
                    case "0":
                        Console.WriteLine("Koniec Proxy.");
                        endLoop = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////





            //////////////////////////////////////////////////////// ADAPTER

            ClubValidator clubValidator = new ClubValidator();

            // Krzyś jako Teenager (walidacja zawiedzie)
            Teenager krzys = new Teenager("Krzyś", 17);
            Console.WriteLine($"{krzys.Name} (wiek: {krzys.Age}) jako Teenager:");
            Console.WriteLine(clubValidator.ValidateEntry(krzys) ? $"{krzys.Name} wchodzi do klubu." : $"{krzys.Name} nie został wpuszczony.");

            Console.WriteLine("");

            // Krzyś jako FakeAdult (walidacja przechodzi)
            FakeAdult fakeKrzys = new FakeAdult("Krzyś", 17);
            Console.WriteLine($"{fakeKrzys.Name} (wiek: {fakeKrzys.Age}) jako FakeAdult:");
            Console.WriteLine(clubValidator.ValidateEntry(fakeKrzys) ? $"{fakeKrzys.Name} wchodzi do klubu." : $"{fakeKrzys.Name} nie został wpuszczony.");

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////




            //////////////////////////////////////////////////////// BRIDGE

            IInterface graphicInterface = new GraphicInterface();
            OperatingSystem linuxSystem = new LinuxSystem(graphicInterface);
            linuxSystem.DisplayMenu();

            Console.WriteLine("");

            IInterface textInterface = new TextInterface();
            OperatingSystem windowsSystem = new WindowsSystem(textInterface);
            windowsSystem.DisplayMenu();

            Console.WriteLine("");
            Console.WriteLine("");

            ////////////////////////////////////////////////////////
            ///





            //////////////////////////////////////////////////////// DECORATOR
            
            Console.WriteLine("DECORATOR:");
            IPayment cardPayment = new CardPayment();
            cardPayment = new SMSNotification(cardPayment);
            cardPayment = new LoyaltyPoints(cardPayment);
            cardPayment = new RedirectToHome(cardPayment);

            Shop shop = new Shop(cardPayment);
            shop.ProcessPayment();

            ////////////////////////////////////////////////////////
            ///




            //////////////////////////////////////////////////////// COMPOSITE

   
            Dish pizza = new Dish("Pizza Margherita", 19.99m);
            Dish pasta = new Dish("Spaghetti Carbonara", 22.99m);
            Dish salad = new Dish("Sałatka grecka", 14.99m);

       
            MenuCategory starters = new MenuCategory("Przystawki");
            MenuCategory mains = new MenuCategory("Dania główne");
            MenuCategory desserts = new MenuCategory("Desery");

        
            starters.Add(salad);
            mains.Add(pizza);
            mains.Add(pasta);
            desserts.Add(new Dish("Tiramisu", 12.99m));

    
            MenuCategory menu = new MenuCategory("Menu restauracji");
            menu.Add(starters);
            menu.Add(mains);
            menu.Add(desserts);


            menu.Display(3);

            ////////////////////////////////////////////////////////
            ///




            //////////////////////////////////////////////////////// Flyweight

            TextureFactory textureFactory = new TextureFactory();

            ITexture treeTexture = textureFactory.GetTexture("tree.png");
            ITexture playerTexture = textureFactory.GetTexture("player.png");
            ITexture rockTexture = textureFactory.GetTexture("rock.png");
            ITexture anotherTreeTexture = textureFactory.GetTexture("tree.png");

            GameObject tree1 = new GameObject(treeTexture);
            GameObject tree2 = new GameObject(treeTexture);
            GameObject player = new GameObject(playerTexture);
            GameObject rock = new GameObject(rockTexture);
            GameObject player2 = new GameObject(playerTexture);

            tree1.Display();
            tree2.Display();
            player.Display();
            rock.Display();
            player2.Display();

            Console.WriteLine($"Czy tekstura 'tree.png' jest współdzielona? {ReferenceEquals(treeTexture, anotherTreeTexture)}");

            //////////////////////////////////////////////////////// Flyweight

        }
    }
}