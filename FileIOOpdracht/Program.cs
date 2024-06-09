using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] content = File.ReadAllLines(@"C:\Users\emiel\Documents\MA\bewijzenmap\periode1.4\prog\2023P4ProgCs2\FileIOOpdracht\leesdezefile.txt");

            foreach (string line in content)
            {
                Console.WriteLine(line);
            }

            string outputDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "output");

            if (!Directory.Exists(outputDirectoryPath))
            {
                Directory.CreateDirectory(outputDirectoryPath);
            }

            string newFilePath = Path.Combine(outputDirectoryPath, "mijnnieuwefile.txt");

            File.WriteAllText(newFilePath, "Dit is de eerste regel in mijnnieuwefile.txt");

            File.AppendAllText(newFilePath, "\nDit is een extra toegevoegde regel.");

            Console.WriteLine($"De nieuwe file is aangemaakt op: {newFilePath}");
        }
    }
}
