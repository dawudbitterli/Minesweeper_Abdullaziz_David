using System.Xml.Schema;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = new Model(20);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Bitte Koordinate eingeben");
                var coordinate = Console.ReadLine();

                model.DoTurn(coordinate);
            }
        }
    }
}