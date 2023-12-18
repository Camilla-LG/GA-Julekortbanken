namespace GA_Julekortbanken
{
    internal class Program
    {
        public List<XmasCard> Cards {  get; set; }
        XmasCard xmasCard = new XmasCard("", "", "");
        public Program()
        {
            Cards = new List<XmasCard>();
        }    

        static void Main()
        {

        }
    }
}
