using System.Text.Json;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);

            foreach (string line in lines)
            {
                string[] typeSplit = line.Split('|');
                string[] consoleMonData = typeSplit[0].Split(',');

                ConsoleMon dataMon = new ConsoleMon
                {
                    name = consoleMonData[0],
                    energy = int.Parse(consoleMonData[4]),
                    health = int.Parse(consoleMonData[2])
                };

                Console.WriteLine($"Name: {dataMon.name}");
                Console.WriteLine($"Energy: {dataMon.energy}");
                Console.WriteLine($"Health: {dataMon.health}");
            }
        }

        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);

            Console.WriteLine(json);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }
    }

   
}
