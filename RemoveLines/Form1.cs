using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RemoveLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCopy.Text = "Copy";
            btnRemove.Text = "Remove";
            btnClear.Text = "Clear";
            CreateContextMenu();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CreateContextMenu()
        {
            var contextMenu = new ContextMenu();
            var menuItem = new MenuItem("Cut");
            menuItem.Click += CutAction;
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Copy");
            menuItem.Click += CopyAction;
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Paste");
            menuItem.Click += PasteAction;
            contextMenu.MenuItems.Add(menuItem);

            txtBoxIn.ContextMenu = contextMenu;
        }

        private string NewLine(string input)
        {
            if (input.Contains(Environment.NewLine)) input = input.Replace(Environment.NewLine, string.Empty);
            return input;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var addGit = "git add ";
            var options = new string[2];
            options[0] = string.Empty;
            options[1] = string.Empty;

            if (rmvModBox.Checked)
                options[0] = "modified:";
            if (rmvDelBox.Checked)
                options[1] = "deleted:";

            var text = txtBoxIn.Text;
            var newWords = new List<string>();

            var words = text.Split(' ');
            foreach (var word in words)
                if (!options.Contains(word) && !string.IsNullOrEmpty(word))
                {
                    newWords.Add(!rmvLinebreakBox.Checked ? word.Trim() : NewLine(word).Trim());
                }

            text = string.Join(" ", newWords.ToArray());

            if (addGitBox.Checked && !words.Contains("git"))
                txtBoxIn.Text = addGit + text.TrimStart();
            else
                txtBoxIn.Text = text.TrimStart();
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
        private void CutAction(object sender, EventArgs e)
        {
            txtBoxIn.Cut();
        }

        private void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, txtBoxIn.Text);
            //Clipboard.Clear();
        }

        private void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text)) txtBoxIn.Text = Clipboard.GetText();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (txtBoxIn.TextLength != 0)
                txtBoxIn.Text = txtBoxIn.Text.Replace(txtBoxIn.Text, string.Empty);

            var checkBoxes = new CheckBox[4];
            checkBoxes[0] = addGitBox;
            checkBoxes[1] = rmvDelBox;
            checkBoxes[2] = rmvLinebreakBox;
            checkBoxes[3] = rmvModBox;

            foreach (var box in checkBoxes)
                if (box.CheckState == CheckState.Checked)
                    box.CheckState = CheckState.Unchecked;
        }
    }
}