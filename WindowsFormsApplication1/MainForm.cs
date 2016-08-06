using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Backend;

namespace DataStructuresMadeEasy
{
    public partial class FrmTextEditor : Form
    {
        StringBuilder word = new StringBuilder();
        AbstractDocument document = new Document("");
        readonly IMarkovTextGeneration markovTextGeneration = new MarkovTextGeneration();

        public FrmTextEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnWordCount_Click(this, e);
            //if (e.KeyChar != ' ' && (e.KeyChar >= 'A' && e.KeyChar <= 'z'))
            //{
            //    word.Append(e.KeyChar);
            //}
            //else if (e.KeyChar == ' ' && word.Length > 0)
            //{
            //    //MessageBox.Show(word.ToString());
            //    word.Clear();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            var text = txtEditor.Text;
            text = Regex.Replace(text, @"\t|\n|\r", "");
            document = new Document(text);

            // ReSharper disable LocalizableElement
            lblSentence.Text = "Sentence Count : " + document.GetNumberOfSentences();
            var wordCount = document.GetNumberOfWords();
            lblWords.Text = "Word Count : " + wordCount;
            lblSyllables.Text = "Syllables Count : " + document.GetNumberOfSyllables();
            lblWelschScore.Text = "Welsch Score : " + document.GetFleschScore();
            // ReSharper restore LocalizableElement
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update abstract document class
            btnWordCount_Click(this, e);

            //get list of sentences
            var sentences = document.GetSentences;

            //update Markov text generation
            foreach (var sentence in sentences.Where(s => s.Length > 1))
            {
                //get a list of words
                var listOfWords = document.GetTokens(new Regex("[a-zA-Z.!]+"), sentence).ToArray();

                for (int i = 1; i < listOfWords.Length; i++)
                {
                    markovTextGeneration.UpdateWordDictionary(listOfWords[i - 1], listOfWords[i]);
                }
                markovTextGeneration.UpdateWordDictionary(listOfWords[listOfWords.Length - 1], listOfWords[0]);
            }

            txtEditor.Text = "";
            StringBuilder newSentence = new StringBuilder();
            foreach (var word in markovTextGeneration.GenerateWords(document.GetNumberOfWords() - document.GetNumberOfWords() / 10))
            {
                newSentence.Append(word + " ");
            }

            txtEditor.Text = newSentence.ToString();
        }
    }
}
