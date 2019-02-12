using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveLines
{
    public partial class Form1 : Form
    {
        string oldText = "";
        string newText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            oldText = txtBoxIn.Text;
            List<string> newWords = new List<string>();

            string[] words = oldText.Split(' ');
            foreach (string word in words)
            {
                if(word != "modified:" && word != "")
                { 
                newWords.Add(word.Trim());
                }
            }

            newText = string.Join(" ", newWords.ToArray());
            txtBoxOut.Text = "git add " + newText;

        }

        private void txtBoxOut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtBoxOut.Text != null)
            { 
                txtBoxOut.SelectAll();
            txtBoxOut.Copy();
            }
        }
    }
}
