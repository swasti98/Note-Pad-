using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotepadApplication
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions.TextToFind = textBox1.Text;
            this.Close();
            if (Functions.TextToFind != "")
            {

                textBox1.Text = Functions.TextToFind;
            }


        }
        private void Find(string textToFind, ref Find findForm)
        {
            if (textBox1.Text.IndexOf(textToFind) == -1)
            {
                MessageBox.Show("Cannot find '" + textToFind + " '");

                findForm.ShowDialog();
            }

            else
            {
                textBox1.SelectionStart = textBox1.Text.IndexOf(Functions.TextToFind);
                textBox1.SelectionLength = textToFind.Length;
            }

        }
    }
}
