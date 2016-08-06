using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend
{
    public class MarkovTextGeneration : IMarkovTextGeneration
    {
        public Dictionary<string, List<string>> WordDictionary { get; private set; }

        public MarkovTextGeneration()
        {
            WordDictionary = new Dictionary<string, List<string>>();
        }

        public void UpdateWordDictionary(string word, string precedingWord)
        {
            if (!WordDictionary.ContainsKey(word))
            {
                WordDictionary.Add(word, new List<string>());
                if (!WordDictionary[word].Contains(precedingWord))
                {
                    WordDictionary[word].Add(precedingWord);
                }
            }
            else
            {
                if (!WordDictionary[word].Contains(precedingWord))
                {
                    WordDictionary[word].Add(precedingWord);
                }
            }
        }

        public List<string> GenerateWords(int numberOfWords)
        {
            var random = new Random();
            var words = new List<string>(numberOfWords);

            for (int i = 0; i < numberOfWords; i++)
            {
                var maxKey = random.Next(0, WordDictionary.Keys.Count - 1);
                var maxValue = random.Next(0, WordDictionary.ElementAt(maxKey).Value.Count - 1);

                words.Add(WordDictionary.ElementAt(maxKey).Value[maxValue]);
            }

            return words;
        } 

    }
}
