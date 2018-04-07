using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace NotepadApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog dlgsave = new SaveFileDialog();
            dlgsave.ShowDialog();
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.ShowDialog();
            using (StreamReader sr = new StreamReader(dlgopen.FileName))
            {
                while (sr.EndOfStream != true)
                {
                    textBox1.Text += Environment.NewLine + sr.ReadLine();
                }
            
            }
            this.Text = dlgopen.FileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] textLines = textBox1.Lines;
            SaveFileDialog dlgsaveas = new SaveFileDialog();
            dlgsaveas.ShowDialog();
            using (StreamWriter sw = new StreamWriter(dlgsaveas.FileName))
            {
                for (int i = 0; i < textLines.GetUpperBound(0) + 1; i++)
                {
                    sw.WriteLine(textLines[i]);
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DateTime dt = new DateTime();
            //string t = Convert.ToString(dt.Date);
            textBox1.Text +=Convert.ToString(DateTime.Now);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowEffects = true;
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                //fd.ShowDialog();
                textBox1.ForeColor = fd.Color;
                textBox1.Font = fd.Font;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog prt = new PrintDialog();
            prt.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Find findForm = new Find();
              findForm.ShowDialog();  
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == false)
            {
                wordWrapToolStripMenuItem.Checked = true;
                textBox1.WordWrap = true;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = false;
                textBox1.WordWrap = false;
            }
        }
        
        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Label ll = new Label();
            ll.Text = "Write information about the company";
            ll.Font = new Font("Arial", 20);
            ll.Dock = DockStyle.Fill;
            f.Controls.Add(ll);
            f.Show();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      
    }
}
