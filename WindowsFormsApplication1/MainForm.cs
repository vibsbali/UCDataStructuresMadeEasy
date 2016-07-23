using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmTextEditor : Form
    {
        StringBuilder word = new StringBuilder();

        public FrmTextEditor()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ' ')
            {
                word.Append(e.KeyChar);
            }
            else
            {
                MessageBox.Show(word.ToString());
                word.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
