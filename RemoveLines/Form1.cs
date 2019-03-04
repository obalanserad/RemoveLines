using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveLines
{
    public partial class Form1 : Form
    {
        string oldText;
        string newText;
        string addGit;
        bool removeLinebreak;
        string[] options= new string[2];

        public Form1()
        {
            InitializeComponent();
            btnCopy.Text = "Copy";
            btnRemove.Text = "Remove";
            CreateContextMenu();
            oldText = string.Empty;
            newText = string.Empty;
            addGit = string.Empty;
            options[0] = string.Empty;
            options[1] = string.Empty;
            //options[2] = string.Empty;
            removeLinebreak = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateContextMenu()
        {
            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            MenuItem menuItem = new MenuItem("Cut");
            menuItem.Click += new EventHandler(CutAction);
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Copy");
            menuItem.Click += new EventHandler(CopyAction);
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Paste");
            menuItem.Click += new EventHandler(PasteAction);
            contextMenu.MenuItems.Add(menuItem);

            txtBoxIn.ContextMenu = contextMenu;
        }

        //NOT IN USE ATM
        private string NewLine(string input)
        {
            if (input.Contains(Environment.NewLine))
            {
                input = input.Replace(Environment.NewLine, String.Empty);
            }
            return input;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            oldText = txtBoxIn.Text;
            List<string> newWords = new List<string>();

            string[] words = oldText.Split(' ');
            foreach (string word in words)
            {
                if(!options.Contains(word) && !string.IsNullOrEmpty(word))
                {
                    if(removeLinebreak == true)
                        newWords.Add(NewLine(word).Trim());
                    else
                        newWords.Add(word.Trim());
                }
            }

            newText = string.Join(" ", newWords.ToArray());
            txtBoxIn.Text = addGit + newText.TrimStart();

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtBoxIn.Text != null)
            { 
                txtBoxIn.SelectAll();
            txtBoxIn.Copy();
            }
        }

        //CUT COPY PASTE ACTIONS
        void CutAction(object sender, EventArgs e)
        {
            txtBoxIn.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, txtBoxIn.Text);
            //Clipboard.Clear();
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                txtBoxIn.Text = Clipboard.GetText();
            }
        }

        private void addGitBox_CheckedChanged(object sender, EventArgs e)
        {
            addGit = "git add ";
        }

        private void rmvModBox_CheckedChanged(object sender, EventArgs e)
        {
            options[0] = "modified:";
        }

        private void rmvDelBox_CheckedChanged(object sender, EventArgs e)
        {
            options[1] = "deleted:";
        }

        private void rmvLinebreakBox_CheckedChanged(object sender, EventArgs e)
        {
            removeLinebreak = true;
        }
    }
}
