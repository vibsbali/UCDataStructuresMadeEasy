namespace WindowsFormsApplication1
{
    partial class FrmTextEditor
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
            this.lstAutoComplete = new System.Windows.Forms.ListBox();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAutoComplete
            // 
            this.lstAutoComplete.FormattingEnabled = true;
            this.lstAutoComplete.Location = new System.Drawing.Point(12, 281);
            this.lstAutoComplete.Name = "lstAutoComplete";
            this.lstAutoComplete.Size = new System.Drawing.Size(209, 82);
            this.lstAutoComplete.TabIndex = 1;
            // 
            // txtEditor
            // 
            this.txtEditor.AcceptsReturn = true;
            this.txtEditor.AcceptsTab = true;
            this.txtEditor.Location = new System.Drawing.Point(12, 12);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(579, 263);
            this.txtEditor.TabIndex = 2;
            this.txtEditor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // btnWordCount
            // 
            this.btnWordCount.Location = new System.Drawing.Point(248, 282);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(124, 26);
            this.btnWordCount.TabIndex = 3;
            this.btnWordCount.Text = "Count Words";
            this.btnWordCount.UseVisualStyleBackColor = true;
            this.btnWordCount.Click += new System.EventHandler(this.btnWordCount_Click);
            // 
            // FrmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 432);
            this.Controls.Add(this.btnWordCount);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lstAutoComplete);
            this.Name = "FrmTextEditor";
            this.Text = "Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstAutoComplete;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnWordCount;
    }
}

