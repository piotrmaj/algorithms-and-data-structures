using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TwoWordAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionPath = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .Parent.Parent.Parent.ToString();
            var testDataPath = Path.Combine(solutionPath, "wordlist.txt");

            var results = FindAnagrams(testDataPath);

            results.ForEach(r => Console.WriteLine($"Found '{r.w1}' '{r.w2}'"));
            Console.WriteLine("Finished. Press any key to exit...");
            Console.ReadKey();
        }

        private static List<(string w1, string w2)> FindAnagrams(string testDataPath)
        {
            var candidatesByCharactersLeft = new Dictionary<string, List<string>>();
            var input = "documenting";
            var inputSorted = string.Concat(input.ToCharArray().OrderBy(c => c));

            string word;
            var results = new List<(string w1, string w2)>();
            var file = new System.IO.StreamReader(testDataPath);
            while ((word = file.ReadLine()) != null)
            {
                results.AddRange(ProcessWord(word, inputSorted, candidatesByCharactersLeft));
            }

            return results;
        }

        private static IEnumerable<(string w1, string w2)> ProcessWord(string word, string inputSorted ,Dictionary<string, List<string>> candidatesByCharactersLeft)
        {
            var result = new List<(string w1, string w2)>();
            var currentWordCharactersSorted = new string(word.ToCharArray().OrderBy(c => c).ToArray());
            if (candidatesByCharactersLeft.ContainsKey(currentWordCharactersSorted))
            {
                foreach (var startWord in candidatesByCharactersLeft[currentWordCharactersSorted])
                {
                    result.Add(new(startWord, word));
                }
            }
            var currentInput = inputSorted;
            var isValid = true;
            foreach (var c in currentWordCharactersSorted)
            {
                var indexOf = currentInput.IndexOf(c);
                if (indexOf != -1)
                {
                    var beforeCurrentChar = currentInput.Substring(0, currentInput.Length - (currentInput.Length - indexOf));
                    var afterCurrentChar = currentInput.Substring(indexOf + 1, currentInput.Length - indexOf - 1);
                    currentInput = beforeCurrentChar + afterCurrentChar;
                }
                else
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                if (!candidatesByCharactersLeft.ContainsKey(currentInput))
                {
                    candidatesByCharactersLeft.Add(currentInput, new List<string>());
                }
                candidatesByCharactersLeft[currentInput].Add(word);
            }

            return result;
        }
    }
}
