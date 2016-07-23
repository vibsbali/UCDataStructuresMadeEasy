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

        /** Return the number of words in this document */
        public int GetNumberOfWords { get; private set; }

        /** Return the number of sentences in this document */
        public virtual int GetNumberOfSentences()
        {
            var regex = new Regex("[.?!]+");

            sentences = regex.Split(Text);
            return sentences.Where(sentence => sentence.Length > 0).ToArray().Length;
        }

        /** Return the number of syllables in this document */

        public int GetNumberOfSyllables
        {
            get; private set;
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

        protected int CountSyllables(string word)
        {
            // TODO: Implement this method so that you can call it from the 
            // getNumSyllables method in BasicDocument (module 1) and 
            // EfficientDocument (module 2).
            return 0;
        }

        /** return the Flesch readability score of this document */
        public double GetFleschScore()
        {
            // TODO: Implement this method in week 1
            return 0.0;
        }
    }
}