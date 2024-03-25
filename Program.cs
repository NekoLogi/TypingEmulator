namespace TypingEmulator
{
    internal class Program
    {
        private const string PATH = "data/";
        private const string FILE = "content.txt";

        static void Main(string[] args)
        {
            CheckStructure();

            string[] content = File.ReadAllLines(PATH + FILE);

            Console.WriteLine("Press 'Enter' to start emutation.");
            Console.ReadLine();
            Console.Clear();

            Emulator.Emulate(content);
        }

        private static void CheckStructure()
        {
            if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
            if (!File.Exists(PATH + FILE))
            {
                Console.WriteLine($"No {FILE} in:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Path.GetFullPath(PATH));
                Console.ResetColor();

                Console.WriteLine("\nPress 'Enter' to close.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
