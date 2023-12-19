using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Julekortbanken
{
    public class XmasCard
    {
        Program program = new Program();

        public string ToName {  get; set; }
        public string FromName { get; set; }
        public string Greeting { get; set; }
        public string Design {  get; set; } 

        public XmasCard(string toName, string fromName, string greeting, string design)
        {
            ToName = toName;
            FromName = fromName;
            Greeting = greeting;
            Design = design;
        }


        public void ShowCards()
        {
            int cardNumber = 1;

            foreach (var card in program.Cards)
            {
                Console.WriteLine($"{cardNumber} Til: {card.ToName}");
                Console.WriteLine($"  {card.Greeting}");
                Console.WriteLine($"  Hilsen {card.FromName}");
                Console.WriteLine();
                cardNumber++;
            }
        }

        public void AddCard()
        {
            Console.WriteLine("Hva slags design vil du ha på julekortet?");
            var designIndex = CardDesign();
            var designChoice = program.Designs[designIndex].DesignName;
            Console.WriteLine($"Du har valgt {designChoice}");
            Console.WriteLine("Hvem vil du sende julekortet til?");
            var toName = Console.ReadLine();
            Console.WriteLine("Hvem vil du sette som avsender?");
            var fromName = Console.ReadLine();
            Console.WriteLine("Hva vil du skrive i kortet?");
            var greeting = Console.ReadLine();


            XmasCard newCard = new XmasCard(toName, fromName, greeting, designChoice);
            program.Cards.Add(newCard);

            Console.WriteLine("Hurra! Du har laget et julekort!");
            Console.WriteLine("Slik ser det nye kortet ditt ut:");
            Console.WriteLine();
            Console.WriteLine($"Til: {newCard.ToName}");
            Console.WriteLine($"{newCard.Greeting}");
            Console.WriteLine($"Hilsen {newCard.FromName}");
            Console.WriteLine();
        }

        private static int CardDesign()
        {
            Console.WriteLine("Velg et av følgende kortdesign:");
            Console.WriteLine("     1. Kort med bilde av julenissen.");
            Console.WriteLine("     2. Kort med bilde av Rudolf.");
            Console.WriteLine("     3. Kort med bilde av et juletre.");
            Console.WriteLine("     4. Kort med bilde av en gave.");

            var cardChoice = Console.ReadKey().KeyChar;

            switch (cardChoice)
            {
                case '1':
                    return 1;
                case '2':
                    return 2;   
                case '3':
                    return 3;
                case '4':
                    return 4;
                default:
                    Console.WriteLine("Velg mellom alternativ 1-4.");
                    return CardDesign();
            }
        }

        public void EditCard()
        {

        }

        public void DeleteCard()
        {

        }
    }
}
