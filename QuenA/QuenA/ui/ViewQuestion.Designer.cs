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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.questionText = new System.Windows.Forms.RichTextBox();
            this.acknowledgementsBox = new System.Windows.Forms.GroupBox();
            this.acknowledgmentsText = new System.Windows.Forms.RichTextBox();
            this.viewAnswerButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.answerText = new System.Windows.Forms.RichTextBox();
            this.questionBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            this.acknowledgementsBox.SuspendLayout();
            this.answerBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.tableLayoutPanel1);
            this.questionBox.Location = new System.Drawing.Point(12, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(768, 169);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Question";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxQuestion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.questionText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxQuestion.Location = new System.Drawing.Point(609, 3);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(150, 144);
            this.pictureBoxQuestion.TabIndex = 6;
            this.pictureBoxQuestion.TabStop = false;
            this.pictureBoxQuestion.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(3, 3);
            this.questionText.MinimumSize = new System.Drawing.Size(4, 20);
            this.questionText.Name = "questionText";
            this.questionText.ReadOnly = true;
            this.questionText.Size = new System.Drawing.Size(600, 144);
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
            // answerBox
            // 
            this.answerBox.Controls.Add(this.tableLayoutPanel2);
            this.answerBox.Location = new System.Drawing.Point(12, 187);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(768, 169);
            this.answerBox.TabIndex = 6;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Answer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxAnswer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.answerText, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 150);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(609, 3);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(150, 144);
            this.pictureBoxAnswer.TabIndex = 6;
            this.pictureBoxAnswer.TabStop = false;
            this.pictureBoxAnswer.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(3, 3);
            this.answerText.MinimumSize = new System.Drawing.Size(4, 20);
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            this.answerText.Size = new System.Drawing.Size(600, 144);
            this.answerText.TabIndex = 1;
            this.answerText.Text = "";
            // 
            // ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 442);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.viewAnswerButton);
            this.Controls.Add(this.acknowledgementsBox);
            this.Controls.Add(this.questionBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewQuestion";
            this.questionBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            this.acknowledgementsBox.ResumeLayout(false);
            this.answerBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.RichTextBox questionText;
        private System.Windows.Forms.GroupBox acknowledgementsBox;
        private System.Windows.Forms.RichTextBox acknowledgmentsText;
        private System.Windows.Forms.Button viewAnswerButton;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxAnswer;
        private System.Windows.Forms.RichTextBox answerText;
    }
}

