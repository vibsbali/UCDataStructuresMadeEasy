using System;
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
            lblWords.Text = "Word Count : " + document.GetNumberOfWords();
            lblSyllables.Text = "Syllables Count : " + document.GetNumberOfSyllables();
            lblWelschScore.Text = "Welsch Score : " + document.GetFleschScore();
            // ReSharper restore LocalizableElement
        }
    }
}
