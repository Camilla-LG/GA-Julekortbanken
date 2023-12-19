using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Julekortbanken
{
    public class Design
    {
        XmasCard xmasCard = new XmasCard("", "", "", "");

        public string DesignName { get; set; } 
       
        public Design(string designName)
        { 
            DesignName = designName;
        }

        public void SantaDesign()
        {
            Console.WriteLine(" ╔══════════════════════════════╗");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║              🎅              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine($"║    {xmasCard.ToName}         ║");
            Console.WriteLine($"║    {xmasCard.Greeting}       ║");
            Console.WriteLine($"║    {xmasCard.FromName}       ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ╚══════════════════════════════╝");
        }

        public void RudolphDesign()
        {
            Console.WriteLine(" ╔══════════════════════════════╗");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║              🦌              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine($"║    {xmasCard.ToName}         ║");
            Console.WriteLine($"║    {xmasCard.Greeting}       ║");
            Console.WriteLine($"║    {xmasCard.FromName}       ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ╚══════════════════════════════╝");
        }

        public void XmasTreeDesign()
        {
            Console.WriteLine(" ╔══════════════════════════════╗");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║              🎄              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine($"║    {xmasCard.ToName}         ║");
            Console.WriteLine($"║    {xmasCard.Greeting}       ║");
            Console.WriteLine($"║    {xmasCard.FromName}       ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ╚══════════════════════════════╝");
        }

        public void GiftDesign()
        {
            Console.WriteLine(" ╔══════════════════════════════╗");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║              🎁              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine($"║    {xmasCard.ToName}         ║");
            Console.WriteLine($"║    {xmasCard.Greeting}       ║");
            Console.WriteLine($"║    {xmasCard.FromName}       ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ║                              ║");
            Console.WriteLine(" ╚══════════════════════════════╝");
        }
    }
}
