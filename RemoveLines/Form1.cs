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
        string oldText = "";
        string newText = "";

        public Form1()
        {
            InitializeComponent();
            btnCopy.Text = "Copy";
            btnRemove.Text = "Remove";
            CreateContextMenu();
            //txtBoxIn.Text = Clipboard.GetText();
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
                if(word != "modified:" && word != string.Empty && word != "deleted:")
                { 
                newWords.Add(word.Trim());
                }
            }

            txtBoxIn.Text = string.Join(" ", newWords.ToArray());
            newText = string.Join(" ", newWords.ToArray());
            txtBoxIn.Text = "git add " + newText;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void CutAction(object sender, EventArgs e)
        {
            txtBoxIn.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Graphics objGraphics;
            Clipboard.SetData(DataFormats.Rtf, txtBoxIn.SelectedRtf);
            Clipboard.Clear();
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                txtBoxIn.Text
                    = Clipboard.GetText();
            }
        }


        private void txtBoxIn_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
                //ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                //MenuItem menuItem = new MenuItem("Cut");
                //menuItem.Click += new EventHandler(CutAction);
                //contextMenu.MenuItems.Add(menuItem);
                //menuItem = new MenuItem("Copy");
                //menuItem.Click += new EventHandler(CopyAction);
                //contextMenu.MenuItems.Add(menuItem);
                //menuItem = new MenuItem("Paste");
                //menuItem.Click += new EventHandler(PasteAction);
                //contextMenu.MenuItems.Add(menuItem);

                //richTextBox1.ContextMenu = contextMenu;
            //}
        }

    }
}
