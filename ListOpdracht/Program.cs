namespace ListOpdracht
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string> { "uil", "kraai", "hond", "papegaai" };

            List<string> birds2 = new List<string> { "meeuw", "duif" };

            birds.AddRange(birds2);

            birds.Remove("hond");

            birds.ForEach(Console.WriteLine);
        }
    }

}


