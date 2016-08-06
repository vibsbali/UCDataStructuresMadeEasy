using System.Collections.Generic;

namespace Backend
{
    public interface IMarkovTextGeneration
    {
        Dictionary<string, List<string>> WordDictionary { get; }
        void UpdateWordDictionary(string word, string precedingWord);
        List<string> GenerateWords(int numberOfWords);
    }
}