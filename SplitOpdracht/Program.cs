namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lees de inhoud van het bestand in de variabele 'content'
            string content = File.ReadAllText("C:\\Users\\emiel\\Documents\\MA\\bewijzenmap\\periode1.4\\prog\\2023P4ProgCs2\\SplitOpdracht\\stringsplit.txt");

            // Split de inhoud op de ':' separator
            string[] keyvalue = content.Split(':');

            // Schrijf de gesplitste strings naar de console
            Console.WriteLine("Key: " + keyvalue[0]);
            Console.WriteLine("Value: " + keyvalue[1]);

            // Split de tweede string (keyvalue[1]) op de ',' separator
            string[] cijfersPerVak = keyvalue[1].Split(',');

            // Schrijf de gesplitste strings naar de console
            foreach (string s in keyvalue)
            {
                Console.WriteLine(s);
            }
        }
    }
}
