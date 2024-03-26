using Newtonsoft.Json;

namespace TypingEmulator
{
    public class Settings
    {
        public General general { get; set; }
        public Emulator emulator { get; set; }
        private const string JSON_FILE = "settings.json";

        public Settings()
        {
            if (!File.Exists(General.PATH + JSON_FILE))
            {
                emulator = new Emulator();
                general = new General();
                Create();
            }
        }


        public class General
        {
            public const string PATH = "data/";
            public string FileName = "content.txt";
        }

        public class Emulator
        {
            public int TypingSpeedFalloffChance = 5;
            public int LowestTypeFalloffMS = 1;
            public int HighestTypeFalloffMS = 130;
            public int FalloffMultiplier = 10;
            public bool AllowWhitespaceFalloff = true;
            public double TypoChance = 3;
            public double ThinkingFalloffChance = 50;
            public int LowestThinkingFalloffMS = 300;
            public int HighestThinkingFalloffMS = 2000;
        }

        private void Create()
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(General.PATH + JSON_FILE, json);
        }

        public Settings Load()
        {
            string json = File.ReadAllText(General.PATH + JSON_FILE);
            return JsonConvert.DeserializeObject<Settings>(json);
        }
    }
}
