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

        public XmasCard(string toName, string fromName, string greeting)
        {
            ToName = toName;
            FromName = fromName;
            Greeting = greeting;
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
            Console.WriteLine("Hvem vil du sende julekortet til?");
            var toName = Console.ReadLine();
            Console.WriteLine("Hvem vil du sette som avsender?");
            var fromName = Console.ReadLine();
            Console.WriteLine("Hva vil du skrive i kortet?");
            var greeting = Console.ReadLine();

     
            XmasCard newCard = new XmasCard(toName, fromName, greeting);
            program.Cards.Add(newCard);

            Console.WriteLine("Hurra! Du har laget et julekort!");
            Console.WriteLine("Slik ser det nye kortet ditt ut:");
            Console.WriteLine();
            Console.WriteLine($"Til: {newCard.ToName}");
            Console.WriteLine($"{newCard.Greeting}");
            Console.WriteLine($"Hilsen {newCard.FromName}");
            Console.WriteLine();
        }

        public void EditCard()
        {

        }

        public void DeleteCard()
        {

        }
    }
}
