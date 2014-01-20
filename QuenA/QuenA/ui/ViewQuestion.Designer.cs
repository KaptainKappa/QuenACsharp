namespace QuenA
{
    partial class ViewQuestion
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
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.questionText = new System.Windows.Forms.RichTextBox();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.answerText = new System.Windows.Forms.RichTextBox();
            this.acknowledgementsBox = new System.Windows.Forms.GroupBox();
            this.acknowledgmentsText = new System.Windows.Forms.RichTextBox();
            this.viewAnswerButton = new System.Windows.Forms.Button();
            this.questionBox.SuspendLayout();
            this.answerBox.SuspendLayout();
            this.acknowledgementsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.questionText);
            this.questionBox.Location = new System.Drawing.Point(12, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(566, 172);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Question";
            // 
            // questionText
            // 
            this.questionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionText.Location = new System.Drawing.Point(3, 16);
            this.questionText.MinimumSize = new System.Drawing.Size(4, 20);
            this.questionText.Name = "questionText";
            this.questionText.ReadOnly = true;
            this.questionText.Size = new System.Drawing.Size(560, 153);
            this.questionText.TabIndex = 1;
            this.questionText.Text = "";
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.answerText);
            this.answerBox.Location = new System.Drawing.Point(12, 187);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(563, 172);
            this.answerBox.TabIndex = 2;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Answer";
            // 
            // answerText
            // 
            this.answerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerText.Location = new System.Drawing.Point(3, 16);
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            this.answerText.Size = new System.Drawing.Size(557, 153);
            this.answerText.TabIndex = 0;
            this.answerText.Text = "";
            // 
            // acknowledgementsBox
            // 
            this.acknowledgementsBox.Controls.Add(this.acknowledgmentsText);
            this.acknowledgementsBox.Location = new System.Drawing.Point(12, 365);
            this.acknowledgementsBox.Name = "acknowledgementsBox";
            this.acknowledgementsBox.Size = new System.Drawing.Size(566, 41);
            this.acknowledgementsBox.TabIndex = 3;
            this.acknowledgementsBox.TabStop = false;
            this.acknowledgementsBox.Text = "Acknowledgements";
            // 
            // acknowledgmentsText
            // 
            this.acknowledgmentsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acknowledgmentsText.Location = new System.Drawing.Point(3, 16);
            this.acknowledgmentsText.Name = "acknowledgmentsText";
            this.acknowledgmentsText.ReadOnly = true;
            this.acknowledgmentsText.Size = new System.Drawing.Size(560, 22);
            this.acknowledgmentsText.TabIndex = 0;
            this.acknowledgmentsText.Text = "";
            // 
            // viewAnswerButton
            // 
            this.viewAnswerButton.Location = new System.Drawing.Point(12, 400);
            this.viewAnswerButton.Name = "viewAnswerButton";
            this.viewAnswerButton.Size = new System.Drawing.Size(86, 23);
            this.viewAnswerButton.TabIndex = 5;
            this.viewAnswerButton.Text = "View Answer";
            this.viewAnswerButton.UseVisualStyleBackColor = true;
            this.viewAnswerButton.Click += new System.EventHandler(this.viewAnswerButton_Click_1);
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 432);
            this.Controls.Add(this.viewAnswerButton);
            this.Controls.Add(this.acknowledgementsBox);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.answerBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionView";
            this.questionBox.ResumeLayout(false);
            this.answerBox.ResumeLayout(false);
            this.acknowledgementsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.RichTextBox questionText;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.RichTextBox answerText;
        private System.Windows.Forms.GroupBox acknowledgementsBox;
        private System.Windows.Forms.RichTextBox acknowledgmentsText;
        private System.Windows.Forms.Button viewAnswerButton;
    }
}

