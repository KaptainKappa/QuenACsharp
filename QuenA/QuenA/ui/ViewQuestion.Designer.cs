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
            this.acknowledgementsBox = new System.Windows.Forms.GroupBox();
            this.acknowledgmentsText = new System.Windows.Forms.RichTextBox();
            this.viewAnswerButton = new System.Windows.Forms.Button();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.splitContainerQuestion = new System.Windows.Forms.SplitContainer();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.splitContainerAnswer = new System.Windows.Forms.SplitContainer();
            this.answerText = new System.Windows.Forms.RichTextBox();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.questionBox.SuspendLayout();
            this.acknowledgementsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuestion)).BeginInit();
            this.splitContainerQuestion.Panel1.SuspendLayout();
            this.splitContainerQuestion.Panel2.SuspendLayout();
            this.splitContainerQuestion.SuspendLayout();
            this.answerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnswer)).BeginInit();
            this.splitContainerAnswer.Panel1.SuspendLayout();
            this.splitContainerAnswer.Panel2.SuspendLayout();
            this.splitContainerAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.splitContainerQuestion);
            this.questionBox.Location = new System.Drawing.Point(12, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(768, 169);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Question";
            // 
            // questionText
            // 
            this.questionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionText.Location = new System.Drawing.Point(0, 0);
            this.questionText.MinimumSize = new System.Drawing.Size(4, 20);
            this.questionText.Name = "questionText";
            this.questionText.ReadOnly = true;
            this.questionText.Size = new System.Drawing.Size(608, 150);
            this.questionText.TabIndex = 1;
            this.questionText.Text = "";
            // 
            // acknowledgementsBox
            // 
            this.acknowledgementsBox.Controls.Add(this.acknowledgmentsText);
            this.acknowledgementsBox.Location = new System.Drawing.Point(12, 362);
            this.acknowledgementsBox.Name = "acknowledgementsBox";
            this.acknowledgementsBox.Size = new System.Drawing.Size(768, 41);
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
            this.acknowledgmentsText.Size = new System.Drawing.Size(762, 22);
            this.acknowledgmentsText.TabIndex = 0;
            this.acknowledgmentsText.Text = "";
            // 
            // viewAnswerButton
            // 
            this.viewAnswerButton.Location = new System.Drawing.Point(12, 412);
            this.viewAnswerButton.Name = "viewAnswerButton";
            this.viewAnswerButton.Size = new System.Drawing.Size(86, 23);
            this.viewAnswerButton.TabIndex = 5;
            this.viewAnswerButton.Text = "View Answer";
            this.viewAnswerButton.UseVisualStyleBackColor = true;
            this.viewAnswerButton.Click += new System.EventHandler(this.viewAnswerButton_Click_1);
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxQuestion.TabIndex = 6;
            this.pictureBoxQuestion.TabStop = false;
            // 
            // splitContainerQuestion
            // 
            this.splitContainerQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQuestion.Location = new System.Drawing.Point(3, 16);
            this.splitContainerQuestion.Name = "splitContainerQuestion";
            // 
            // splitContainerQuestion.Panel1
            // 
            this.splitContainerQuestion.Panel1.Controls.Add(this.questionText);
            // 
            // splitContainerQuestion.Panel2
            // 
            this.splitContainerQuestion.Panel2.Controls.Add(this.pictureBoxQuestion);
            this.splitContainerQuestion.Size = new System.Drawing.Size(762, 150);
            this.splitContainerQuestion.SplitterDistance = 608;
            this.splitContainerQuestion.TabIndex = 2;
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.splitContainerAnswer);
            this.answerBox.Location = new System.Drawing.Point(12, 187);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(768, 169);
            this.answerBox.TabIndex = 6;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Answer";
            // 
            // splitContainerAnswer
            // 
            this.splitContainerAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAnswer.Location = new System.Drawing.Point(3, 16);
            this.splitContainerAnswer.Name = "splitContainerAnswer";
            // 
            // splitContainerAnswer.Panel1
            // 
            this.splitContainerAnswer.Panel1.Controls.Add(this.answerText);
            // 
            // splitContainerAnswer.Panel2
            // 
            this.splitContainerAnswer.Panel2.Controls.Add(this.pictureBoxAnswer);
            this.splitContainerAnswer.Size = new System.Drawing.Size(762, 150);
            this.splitContainerAnswer.SplitterDistance = 608;
            this.splitContainerAnswer.TabIndex = 2;
            // 
            // answerText
            // 
            this.answerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerText.Location = new System.Drawing.Point(0, 0);
            this.answerText.MinimumSize = new System.Drawing.Size(4, 20);
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            this.answerText.Size = new System.Drawing.Size(608, 150);
            this.answerText.TabIndex = 1;
            this.answerText.Text = "";
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxAnswer.TabIndex = 6;
            this.pictureBoxAnswer.TabStop = false;
            // 
            // ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 447);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.viewAnswerButton);
            this.Controls.Add(this.acknowledgementsBox);
            this.Controls.Add(this.questionBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewQuestion";
            this.questionBox.ResumeLayout(false);
            this.acknowledgementsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            this.splitContainerQuestion.Panel1.ResumeLayout(false);
            this.splitContainerQuestion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuestion)).EndInit();
            this.splitContainerQuestion.ResumeLayout(false);
            this.answerBox.ResumeLayout(false);
            this.splitContainerAnswer.Panel1.ResumeLayout(false);
            this.splitContainerAnswer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnswer)).EndInit();
            this.splitContainerAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.RichTextBox questionText;
        private System.Windows.Forms.GroupBox acknowledgementsBox;
        private System.Windows.Forms.RichTextBox acknowledgmentsText;
        private System.Windows.Forms.Button viewAnswerButton;
        private System.Windows.Forms.SplitContainer splitContainerQuestion;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.SplitContainer splitContainerAnswer;
        private System.Windows.Forms.RichTextBox answerText;
        private System.Windows.Forms.PictureBox pictureBoxAnswer;
    }
}

