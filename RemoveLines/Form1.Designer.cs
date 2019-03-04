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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(343, 279);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtBoxIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RemoveLines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxIn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCopy;
    }
}

