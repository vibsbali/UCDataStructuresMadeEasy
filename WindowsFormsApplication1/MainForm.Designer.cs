namespace DataStructuresMadeEasy
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
            this.btnPerformAnalytics = new System.Windows.Forms.Button();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblSyllables = new System.Windows.Forms.Label();
            this.lblSentence = new System.Windows.Forms.Label();
            this.lblWelschScore = new System.Windows.Forms.Label();
            this.btnGenerateText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAutoComplete
            // 
            this.lstAutoComplete.FormattingEnabled = true;
            this.lstAutoComplete.Location = new System.Drawing.Point(12, 293);
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
            this.txtEditor.Size = new System.Drawing.Size(591, 259);
            this.txtEditor.TabIndex = 2;
            this.txtEditor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // btnPerformAnalytics
            // 
            this.btnPerformAnalytics.Location = new System.Drawing.Point(227, 293);
            this.btnPerformAnalytics.Name = "btnPerformAnalytics";
            this.btnPerformAnalytics.Size = new System.Drawing.Size(124, 26);
            this.btnPerformAnalytics.TabIndex = 3;
            this.btnPerformAnalytics.Text = "Perform Analytics";
            this.btnPerformAnalytics.UseVisualStyleBackColor = true;
            this.btnPerformAnalytics.Click += new System.EventHandler(this.btnWordCount_Click);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(13, 274);
            this.lblWords.MinimumSize = new System.Drawing.Size(100, 10);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(100, 13);
            this.lblWords.TabIndex = 4;
            this.lblWords.Text = "Word Count";
            // 
            // lblSyllables
            // 
            this.lblSyllables.AutoSize = true;
            this.lblSyllables.Location = new System.Drawing.Point(119, 274);
            this.lblSyllables.MinimumSize = new System.Drawing.Size(100, 10);
            this.lblSyllables.Name = "lblSyllables";
            this.lblSyllables.Size = new System.Drawing.Size(100, 13);
            this.lblSyllables.TabIndex = 5;
            this.lblSyllables.Text = "Syllables Count";
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(224, 273);
            this.lblSentence.MinimumSize = new System.Drawing.Size(100, 10);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(100, 13);
            this.lblSentence.TabIndex = 6;
            this.lblSentence.Text = "Sentence Count";
            // 
            // lblWelschScore
            // 
            this.lblWelschScore.AutoSize = true;
            this.lblWelschScore.Location = new System.Drawing.Point(359, 273);
            this.lblWelschScore.MinimumSize = new System.Drawing.Size(100, 10);
            this.lblWelschScore.Name = "lblWelschScore";
            this.lblWelschScore.Size = new System.Drawing.Size(100, 13);
            this.lblWelschScore.TabIndex = 7;
            this.lblWelschScore.Text = "Welsch Score";
            // 
            // btnGenerateText
            // 
            this.btnGenerateText.Location = new System.Drawing.Point(371, 293);
            this.btnGenerateText.Name = "btnGenerateText";
            this.btnGenerateText.Size = new System.Drawing.Size(125, 26);
            this.btnGenerateText.TabIndex = 8;
            this.btnGenerateText.Text = "Generate Text";
            this.btnGenerateText.UseVisualStyleBackColor = true;
            this.btnGenerateText.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 432);
            this.Controls.Add(this.btnGenerateText);
            this.Controls.Add(this.lblWelschScore);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.lblSyllables);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.btnPerformAnalytics);
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
        private System.Windows.Forms.Button btnPerformAnalytics;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblSyllables;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.Label lblWelschScore;
        private System.Windows.Forms.Button btnGenerateText;
    }
}

