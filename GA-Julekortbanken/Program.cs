using System.ComponentModel;

namespace GA_Julekortbanken
{
    public class Program
    {
        public List<XmasCard> Cards {  get; set; }
        public Program()
        {
            Cards = new List<XmasCard>();
        }    
        static void Main()
        {
            bool RunProgram = true;
            XmasCard xmasCard = new XmasCard("", "", "");

            Console.WriteLine();
            Console.WriteLine(" *** JULEKORTBANKEN *** ");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            while (RunProgram)
            {
                Console.WriteLine("Hovedmeny:  ");
                Console.WriteLine("1. Vis alle julekortene");
                Console.WriteLine("2. Lag et julekort");
                Console.WriteLine("3. Rediger et julekort");
                Console.WriteLine("4. Slett et julekort");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                int userChoice = Console.ReadKey().KeyChar;

                switch (userChoice)
                {
                    case '1':
                        xmasCard.ShowCards();
                        break;
                    case '2':
                        xmasCard.AddCard();
                        break;
                    case '3':
                        Console.WriteLine(" Prøv igjen senere");
                        break;
                    case '4':
                        Console.WriteLine(" Prøv igjen senere");
                        break;
                    case '5':
                        RunProgram = false;
                        Console.WriteLine(" Hadet fint!");
                        break;
                    default: 
                        Console.WriteLine(" Velg et av tallene 1-5.");
                        break;
                }

            }
        }
    }
}
