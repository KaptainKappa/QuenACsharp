namespace QuenA.ui
{
    partial class AddQuestion
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
            this.formattingBox = new System.Windows.Forms.GroupBox();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicsButton = new System.Windows.Forms.Button();
            this.boldTextButton = new System.Windows.Forms.Button();
            this.textHighlightBox = new System.Windows.Forms.Panel();
            this.highlightColourRadio = new System.Windows.Forms.RadioButton();
            this.textColourRadio = new System.Windows.Forms.RadioButton();
            this.colourBox = new System.Windows.Forms.Panel();
            this.whiteColourButton = new System.Windows.Forms.Button();
            this.blackTextButton = new System.Windows.Forms.Button();
            this.customColourButton = new System.Windows.Forms.Button();
            this.redTextButton = new System.Windows.Forms.Button();
            this.blueTextButton = new System.Windows.Forms.Button();
            this.orangeTextButton = new System.Windows.Forms.Button();
            this.greenTextButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acknowledgementsBox = new System.Windows.Forms.GroupBox();
            this.acknowledgmentsText = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.questionBox.SuspendLayout();
            this.answerBox.SuspendLayout();
            this.formattingBox.SuspendLayout();
            this.textHighlightBox.SuspendLayout();
            this.colourBox.SuspendLayout();
            this.acknowledgementsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.questionText);
            this.questionBox.Location = new System.Drawing.Point(12, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(549, 172);
            this.questionBox.TabIndex = 1;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Question";
            // 
            // questionText
            // 
            this.questionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionText.Location = new System.Drawing.Point(3, 16);
            this.questionText.MinimumSize = new System.Drawing.Size(4, 20);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(543, 153);
            this.questionText.TabIndex = 1;
            this.questionText.Text = "";
            this.questionText.Enter += new System.EventHandler(this.changeFocusedBox);
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.answerText);
            this.answerBox.Location = new System.Drawing.Point(12, 190);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(549, 172);
            this.answerBox.TabIndex = 3;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Answer";
            // 
            // answerText
            // 
            this.answerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerText.Location = new System.Drawing.Point(3, 16);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(543, 153);
            this.answerText.TabIndex = 0;
            this.answerText.Text = "";
            this.answerText.Enter += new System.EventHandler(this.changeFocusedBox);
            // 
            // formattingBox
            // 
            this.formattingBox.Controls.Add(this.underlineButton);
            this.formattingBox.Controls.Add(this.italicsButton);
            this.formattingBox.Controls.Add(this.boldTextButton);
            this.formattingBox.Controls.Add(this.textHighlightBox);
            this.formattingBox.Controls.Add(this.colourBox);
            this.formattingBox.Location = new System.Drawing.Point(567, 12);
            this.formattingBox.Name = "formattingBox";
            this.formattingBox.Size = new System.Drawing.Size(247, 350);
            this.formattingBox.TabIndex = 5;
            this.formattingBox.TabStop = false;
            this.formattingBox.Text = "Formatting";
            // 
            // underlineButton
            // 
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.Location = new System.Drawing.Point(166, 16);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(75, 23);
            this.underlineButton.TabIndex = 10;
            this.underlineButton.Text = "Underline";
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // italicsButton
            // 
            this.italicsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicsButton.Location = new System.Drawing.Point(87, 16);
            this.italicsButton.Name = "italicsButton";
            this.italicsButton.Size = new System.Drawing.Size(75, 23);
            this.italicsButton.TabIndex = 9;
            this.italicsButton.Text = "Italics";
            this.italicsButton.UseVisualStyleBackColor = true;
            this.italicsButton.Click += new System.EventHandler(this.italicsButton_Click);
            // 
            // boldTextButton
            // 
            this.boldTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldTextButton.Location = new System.Drawing.Point(6, 16);
            this.boldTextButton.Name = "boldTextButton";
            this.boldTextButton.Size = new System.Drawing.Size(75, 23);
            this.boldTextButton.TabIndex = 8;
            this.boldTextButton.Text = "Bold";
            this.boldTextButton.UseVisualStyleBackColor = true;
            this.boldTextButton.Click += new System.EventHandler(this.boldTextButton_Click);
            // 
            // textHighlightBox
            // 
            this.textHighlightBox.Controls.Add(this.highlightColourRadio);
            this.textHighlightBox.Controls.Add(this.textColourRadio);
            this.textHighlightBox.Location = new System.Drawing.Point(6, 45);
            this.textHighlightBox.Name = "textHighlightBox";
            this.textHighlightBox.Size = new System.Drawing.Size(235, 46);
            this.textHighlightBox.TabIndex = 7;
            // 
            // highlightColourRadio
            // 
            this.highlightColourRadio.AutoSize = true;
            this.highlightColourRadio.Location = new System.Drawing.Point(3, 26);
            this.highlightColourRadio.Name = "highlightColourRadio";
            this.highlightColourRadio.Size = new System.Drawing.Size(66, 17);
            this.highlightColourRadio.TabIndex = 1;
            this.highlightColourRadio.Text = "Highlight";
            this.highlightColourRadio.UseVisualStyleBackColor = true;
            // 
            // textColourRadio
            // 
            this.textColourRadio.AutoSize = true;
            this.textColourRadio.Checked = true;
            this.textColourRadio.Location = new System.Drawing.Point(3, 3);
            this.textColourRadio.Name = "textColourRadio";
            this.textColourRadio.Size = new System.Drawing.Size(46, 17);
            this.textColourRadio.TabIndex = 0;
            this.textColourRadio.TabStop = true;
            this.textColourRadio.Text = "Text";
            this.textColourRadio.UseVisualStyleBackColor = true;
            // 
            // colourBox
            // 
            this.colourBox.Controls.Add(this.whiteColourButton);
            this.colourBox.Controls.Add(this.blackTextButton);
            this.colourBox.Controls.Add(this.customColourButton);
            this.colourBox.Controls.Add(this.redTextButton);
            this.colourBox.Controls.Add(this.blueTextButton);
            this.colourBox.Controls.Add(this.orangeTextButton);
            this.colourBox.Controls.Add(this.greenTextButton);
            this.colourBox.Location = new System.Drawing.Point(6, 97);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(235, 26);
            this.colourBox.TabIndex = 6;
            // 
            // whiteColourButton
            // 
            this.whiteColourButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.whiteColourButton.BackColor = System.Drawing.Color.White;
            this.whiteColourButton.Location = new System.Drawing.Point(131, 3);
            this.whiteColourButton.Name = "whiteColourButton";
            this.whiteColourButton.Size = new System.Drawing.Size(20, 20);
            this.whiteColourButton.TabIndex = 11;
            this.whiteColourButton.UseVisualStyleBackColor = false;
            this.whiteColourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // blackTextButton
            // 
            this.blackTextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blackTextButton.BackColor = System.Drawing.Color.Black;
            this.blackTextButton.Location = new System.Drawing.Point(105, 3);
            this.blackTextButton.Name = "blackTextButton";
            this.blackTextButton.Size = new System.Drawing.Size(20, 20);
            this.blackTextButton.TabIndex = 3;
            this.blackTextButton.UseVisualStyleBackColor = false;
            this.blackTextButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // customColourButton
            // 
            this.customColourButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.customColourButton.Location = new System.Drawing.Point(157, 3);
            this.customColourButton.Name = "customColourButton";
            this.customColourButton.Size = new System.Drawing.Size(75, 20);
            this.customColourButton.TabIndex = 5;
            this.customColourButton.Text = "Custom...";
            this.customColourButton.UseVisualStyleBackColor = true;
            this.customColourButton.Click += new System.EventHandler(this.customColourButton_Click);
            // 
            // redTextButton
            // 
            this.redTextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.redTextButton.BackColor = System.Drawing.Color.Red;
            this.redTextButton.Location = new System.Drawing.Point(1, 3);
            this.redTextButton.Name = "redTextButton";
            this.redTextButton.Size = new System.Drawing.Size(20, 20);
            this.redTextButton.TabIndex = 0;
            this.redTextButton.UseVisualStyleBackColor = false;
            this.redTextButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // blueTextButton
            // 
            this.blueTextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blueTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.blueTextButton.Location = new System.Drawing.Point(79, 3);
            this.blueTextButton.Name = "blueTextButton";
            this.blueTextButton.Size = new System.Drawing.Size(20, 20);
            this.blueTextButton.TabIndex = 4;
            this.blueTextButton.UseVisualStyleBackColor = false;
            this.blueTextButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // orangeTextButton
            // 
            this.orangeTextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.orangeTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeTextButton.Location = new System.Drawing.Point(27, 3);
            this.orangeTextButton.Name = "orangeTextButton";
            this.orangeTextButton.Size = new System.Drawing.Size(20, 20);
            this.orangeTextButton.TabIndex = 1;
            this.orangeTextButton.UseVisualStyleBackColor = false;
            this.orangeTextButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // greenTextButton
            // 
            this.greenTextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.greenTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.greenTextButton.Location = new System.Drawing.Point(53, 3);
            this.greenTextButton.Name = "greenTextButton";
            this.greenTextButton.Size = new System.Drawing.Size(20, 20);
            this.greenTextButton.TabIndex = 2;
            this.greenTextButton.UseVisualStyleBackColor = false;
            this.greenTextButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(96, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acknowledgementsBox
            // 
            this.acknowledgementsBox.Controls.Add(this.acknowledgmentsText);
            this.acknowledgementsBox.Location = new System.Drawing.Point(12, 368);
            this.acknowledgementsBox.Name = "acknowledgementsBox";
            this.acknowledgementsBox.Size = new System.Drawing.Size(546, 41);
            this.acknowledgementsBox.TabIndex = 8;
            this.acknowledgementsBox.TabStop = false;
            this.acknowledgementsBox.Text = "Acknowledgements";
            // 
            // acknowledgmentsText
            // 
            this.acknowledgmentsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acknowledgmentsText.Location = new System.Drawing.Point(3, 16);
            this.acknowledgmentsText.Name = "acknowledgmentsText";
            this.acknowledgmentsText.Size = new System.Drawing.Size(540, 22);
            this.acknowledgmentsText.TabIndex = 0;
            this.acknowledgmentsText.Text = "";
            this.acknowledgmentsText.Enter += new System.EventHandler(this.changeFocusedBox);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.acknowledgementsBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.formattingBox);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.questionBox);
            this.Name = "AddQuestion";
            this.Text = "Add a Question";
            this.questionBox.ResumeLayout(false);
            this.answerBox.ResumeLayout(false);
            this.formattingBox.ResumeLayout(false);
            this.textHighlightBox.ResumeLayout(false);
            this.textHighlightBox.PerformLayout();
            this.colourBox.ResumeLayout(false);
            this.acknowledgementsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.RichTextBox questionText;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.RichTextBox answerText;
        private System.Windows.Forms.GroupBox formattingBox;
        private System.Windows.Forms.Panel textHighlightBox;
        private System.Windows.Forms.RadioButton highlightColourRadio;
        private System.Windows.Forms.RadioButton textColourRadio;
        private System.Windows.Forms.Panel colourBox;
        private System.Windows.Forms.Button blackTextButton;
        private System.Windows.Forms.Button customColourButton;
        private System.Windows.Forms.Button redTextButton;
        private System.Windows.Forms.Button blueTextButton;
        private System.Windows.Forms.Button orangeTextButton;
        private System.Windows.Forms.Button greenTextButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox acknowledgementsBox;
        private System.Windows.Forms.RichTextBox acknowledgmentsText;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button italicsButton;
        private System.Windows.Forms.Button boldTextButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button whiteColourButton;
    }
}