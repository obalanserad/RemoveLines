namespace RemoveLines
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxIn = new System.Windows.Forms.RichTextBox();
            this.txtBoxOut = new System.Windows.Forms.RichTextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rmvDeleteBox = new System.Windows.Forms.CheckBox();
            this.rmvModifiedBox = new System.Windows.Forms.CheckBox();
            this.rmvNewlineBox = new System.Windows.Forms.CheckBox();
            this.addGitBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxIn
            // 
            this.txtBoxIn.BackColor = System.Drawing.Color.Black;
            this.txtBoxIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxIn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIn.ForeColor = System.Drawing.Color.Red;
            this.txtBoxIn.Location = new System.Drawing.Point(9, 2);
            this.txtBoxIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxIn.Name = "txtBoxIn";
            this.txtBoxIn.Size = new System.Drawing.Size(327, 233);
            this.txtBoxIn.TabIndex = 0;
            this.txtBoxIn.Text = "";
            // 
            // txtBoxOut
            // 
            this.txtBoxOut.BackColor = System.Drawing.Color.Black;
            this.txtBoxOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOut.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtBoxOut.Location = new System.Drawing.Point(606, 2);
            this.txtBoxOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxOut.Name = "txtBoxOut";
            this.txtBoxOut.Size = new System.Drawing.Size(58, 45);
            this.txtBoxOut.TabIndex = 0;
            this.txtBoxOut.Text = "";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(182, 240);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(261, 240);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 30);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(564, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // rmvDeleteBox
            // 
            this.rmvDeleteBox.AutoSize = true;
            this.rmvDeleteBox.Location = new System.Drawing.Point(341, 30);
            this.rmvDeleteBox.Name = "rmvDeleteBox";
            this.rmvDeleteBox.Size = new System.Drawing.Size(111, 17);
            this.rmvDeleteBox.TabIndex = 3;
            this.rmvDeleteBox.Text = "Remove \"delete:\"";
            this.rmvDeleteBox.UseVisualStyleBackColor = true;
            // 
            // rmvModifiedBox
            // 
            this.rmvModifiedBox.AutoSize = true;
            this.rmvModifiedBox.Location = new System.Drawing.Point(341, 54);
            this.rmvModifiedBox.Name = "rmvModifiedBox";
            this.rmvModifiedBox.Size = new System.Drawing.Size(121, 17);
            this.rmvModifiedBox.TabIndex = 4;
            this.rmvModifiedBox.Text = "Remove \"modified:\"";
            this.rmvModifiedBox.UseVisualStyleBackColor = true;
            // 
            // rmvNewlineBox
            // 
            this.rmvNewlineBox.AutoSize = true;
            this.rmvNewlineBox.Location = new System.Drawing.Point(341, 78);
            this.rmvNewlineBox.Name = "rmvNewlineBox";
            this.rmvNewlineBox.Size = new System.Drawing.Size(105, 17);
            this.rmvNewlineBox.TabIndex = 5;
            this.rmvNewlineBox.Text = "Remove newline";
            this.rmvNewlineBox.UseVisualStyleBackColor = true;
            // 
            // addGitBox
            // 
            this.addGitBox.AutoSize = true;
            this.addGitBox.Location = new System.Drawing.Point(341, 7);
            this.addGitBox.Name = "addGitBox";
            this.addGitBox.Size = new System.Drawing.Size(90, 17);
            this.addGitBox.TabIndex = 6;
            this.addGitBox.Text = "Add \"git add\"";
            this.addGitBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(675, 279);
            this.Controls.Add(this.addGitBox);
            this.Controls.Add(this.rmvNewlineBox);
            this.Controls.Add(this.rmvModifiedBox);
            this.Controls.Add(this.rmvDeleteBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtBoxOut);
            this.Controls.Add(this.txtBoxIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RemoveLines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxIn;
        private System.Windows.Forms.RichTextBox txtBoxOut;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox rmvDeleteBox;
        private System.Windows.Forms.CheckBox rmvModifiedBox;
        private System.Windows.Forms.CheckBox rmvNewlineBox;
        private System.Windows.Forms.CheckBox addGitBox;
    }
}

