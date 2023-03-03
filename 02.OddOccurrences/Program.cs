namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<string, int> allWords = new Dictionary<string, int>();

            foreach (string word in words) 
            {
                string wordToLower = word.ToLower();
                
                if (!allWords.ContainsKey(wordToLower))
                {
                    allWords.Add(wordToLower, 0);
                }
                allWords[word]++;
            }
            
            var result = allWords
                .Where(x => x.Value % 2 != 0)
                .Select(x => x.Key)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}