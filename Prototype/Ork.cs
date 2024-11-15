using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Prototype
{
    internal class Ork
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public void CreateAndShowOrk()
        {
            Ork originalOrk = new Ork
            {
                Name = "Grimmer",
                Strength = 50
            };

            // Lista klonów
            List<Ork> orkClones = new List<Ork>();
            Random random = new Random();

            for (int i = 0; i < 5; i++) // Tworzymy 5 klonów
            {
                string serializedOrk = JsonConvert.SerializeObject(originalOrk);

                Ork clonedOrk = JsonConvert.DeserializeObject<Ork>(serializedOrk);

                clonedOrk.Strength = random.Next(10, 100); // Siła w zakresie od 10 do 100

                orkClones.Add(clonedOrk);
            }

            Console.WriteLine("Lista klonów:");
            foreach (var ork in orkClones)
            {
                Console.WriteLine($"Imię: {ork.Name}, Siła: {ork.Strength}");
            }
        }
    }
}
