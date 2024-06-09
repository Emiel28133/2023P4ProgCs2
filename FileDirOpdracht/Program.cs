namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\emiel\Documents\MA\bewijzenmap\periode1.4\prog\2023P4ProgCs2");

            FileInfo[] files = dir.GetFiles();

            Console.WriteLine("Files:");
            for (int kaas = 0; kaas < files.Length; kaas++)
            {
                Console.WriteLine(files[kaas].Name);
            }

            DirectoryInfo[] directories = dir.GetDirectories();

            Console.WriteLine("\nDirectories:");
            for (int pindakaas = 0; pindakaas < directories.Length; pindakaas++)
            {
                Console.WriteLine(directories[pindakaas].Name);
            }
        }
    }
}
