using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Backend
{
    public abstract class AbstractDocument
    {
        public string Text { get; }
        private IEnumerable<string> sentences;
        private List<string> words;

        /** Return the number of words in this document */
        public virtual int GetNumberOfWords()
        {
            var regex = new Regex("[a-zA-Z]+");
            words = new List<string>();

            //If you like to match the first occurence then use Match method otherwise use matches
            MatchCollection result = regex.Matches(Text);
            foreach (var match in result)
            {
                words.Add(match.ToString());
            }
            
            return words.Count;
        }

        /** Return the number of sentences in this document */
        public virtual int GetNumberOfSentences()
        {
            var regex = new Regex("[.?!]+");

            sentences = regex.Split(Text).Where(sentence => sentence.Length > 0);
            return sentences.ToArray().Length;
        }

        /** Return the number of syllables in this document */
        public virtual int GetNumberOfSyllables()
        {
            var regex = new Regex("[aeiouy]+[^$e(,.:;!?)]");
            var numberOfSyllables = regex.Matches(Text).Count;

            return numberOfSyllables;
        }

        /** Create a new document from the given text.
        * Because this class is abstract, this is used only from subclasses.
        * @param text The text of the document.
        */
        protected AbstractDocument(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }

            Text = text;
        }

        /** Returns the tokens that match the regex pattern from the document text string.
	 * @param pattern A regular expression string specifying the 
	 *   token pattern desired
	 * @return A List of tokens from the document text that match the regex 
	 *   pattern
	 */
        public IEnumerable<string> GetTokens(Regex pattern)
        {
            if (pattern == null)
            {
                throw new ArgumentNullException();
            }

            var result = pattern.Split(Text);
            return result;
        }

        //returns number Of Syllables in a word
        protected int CountSyllables(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException();
            }

            var regex = new Regex("[aeiouy]+[^$e(,.:;!?)]");
            var numberOfSyllables = regex.Matches(word).Count;

            return numberOfSyllables;
        }

        /** return the Flesch readability score of this document */
        public virtual double GetFleschScore()
        {
            return 206.835 - (1.015*((double)GetNumberOfWords()/GetNumberOfSentences())) -
                   (84.6*((double)GetNumberOfSyllables()/GetNumberOfWords()));
            
        }
    }
}