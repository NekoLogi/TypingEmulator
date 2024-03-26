namespace TypingEmulator
{
    internal class Emulator
    {
        private static Random Rnd = new Random();
        public static void Emulate(string[] content)
        {
            foreach (var line in content)
            {
                TypeLine(line);
                Console.Write("\n");
            }
        }

        private static void TypeLine(string line)
        {
            foreach (char c in line)
            {
                int typingSpeed = Rnd.Next(1, 130);

                if (Chance(5))
                    typingSpeed = typingSpeed * 10;
                else if (char.IsWhiteSpace(c))
                    typingSpeed = 0;
                Thread.Sleep(typingSpeed);

                MakeTypo(c, typingSpeed);
                Console.Write(c);
            }
        }

        private static void MakeTypo(char c, int typingSpeed)
        {
            if (Chance(1) && !char.IsWhiteSpace(c))
            {
                char randomChar = (char)Rnd.Next(97, 123);
                Console.Write(randomChar);

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
