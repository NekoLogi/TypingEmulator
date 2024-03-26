namespace TypingEmulator
{
    internal class Program
    {
        public static Settings Settings = new Settings().Load();

        static void Main(string[] args)
        {
            CheckStructure();

            string[] content = File.ReadAllLines(Settings.General.PATH + Settings.general.FileName);

            Console.WriteLine("Press 'Enter' to start emutation.");
            Console.ReadLine();
            Console.Clear();

            new Emulator(Settings.emulator)
                .Emulate(content);
        }

        private static void CheckStructure()
        {
            if (!Directory.Exists(Settings.General.PATH))
                Directory.CreateDirectory(Settings.General.PATH);
            if (!File.Exists(Settings.General.PATH + Settings.general.FileName))
            {
                Console.WriteLine($"No {Settings.general.FileName} in:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Path.GetFullPath(Settings.General.PATH));
                Console.ResetColor();

                Console.WriteLine("\nPress 'Enter' to close.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
