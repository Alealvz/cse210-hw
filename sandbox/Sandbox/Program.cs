class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(new Reference("John", "3:16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(5);
        }
    }

   
    static void LoadScripturesFromFile()
    {
        var scriptures = new List<Scripture>();
        var filePath = "scriptures.txt";

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                var reference = parts[0];
                var text = parts[1];

                var book = reference.Split(' ')[0];
                var verse = reference.Split(' ')[1];

                var scriptureReference = new Reference(book, verse);
                var scripture = new Scripture(scriptureReference, text);

                scriptures.Add(scripture);
            }
        }

    
        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.ToString());
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords(5);
        }
    }
}