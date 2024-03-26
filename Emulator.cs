namespace TypingEmulator
{
    internal class Emulator(Settings.Emulator emulator)
    {
        private static Random Rnd = new Random();
        public Settings.Emulator Settings { get; set; } = emulator;


        public void Emulate(string[] content)
        {
            foreach (var line in content)
            {
                TypeLine(line);
                Console.Write("\n");
            }
        }

        private void TypeLine(string line)
        {
            foreach (char c in line)
            {
                int typingSpeed = Rnd.Next(
                    Settings.LowestTypeFalloffMS,
                    Settings.HighestTypeFalloffMS);

                if (Chance(Settings.TypingSpeedFalloffPercentage) && char.IsWhiteSpace(c) && Settings.AllowWhitespaceFalloff)
                    typingSpeed *= Settings.FalloffMultiplier;
                else if (char.IsWhiteSpace(c) || !Settings.AllowWhitespaceFalloff)
                    typingSpeed = 0;

                Thread.Sleep(typingSpeed);

                MakeTypo(c, typingSpeed);
                Console.Write(c);
            }
            if (Chance(Settings.ThinkingFalloffChance))
                Thread.Sleep(Rnd.Next(
                    Settings.LowestThinkingFalloffMS,
                    Settings.HighestThinkingFalloffMS));
        }

        private void MakeTypo(char c, int typingSpeed)
        {
            if (Chance(Settings.TypoChance) && !char.IsWhiteSpace(c))
            {
                char randomChar = (char)Rnd.Next(97, 123);
                Console.Write(randomChar);

                if (Chance(Settings.ThinkingFalloffChance))
                    Thread.Sleep(Rnd.Next(
                        Settings.LowestThinkingFalloffMS,
                        Settings.HighestThinkingFalloffMS));
                else
                    Thread.Sleep(typingSpeed);

                Console.Write("\b");
                Thread.Sleep(typingSpeed);
            }
        }

        private static bool Chance(double percentage)
        {
            if ((Rnd.NextDouble() * 100) < percentage)
                return true;
            return false;
        }
    }
}
