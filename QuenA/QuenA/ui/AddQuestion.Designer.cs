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
            this.splitContainerQuestion = new System.Windows.Forms.SplitContainer();
            this.questionText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.imageLabelQuestion = new System.Windows.Forms.Label();
            this.imageThumbnailQuestion = new System.Windows.Forms.PictureBox();
            this.attachImageButtonQuestion = new System.Windows.Forms.Button();
            this.formattingBox = new System.Windows.Forms.GroupBox();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicsButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
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
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.splitContainerAnswer = new System.Windows.Forms.SplitContainer();
            this.answerText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.imageLabelAnswer = new System.Windows.Forms.Label();
            this.imageThumbnailAnswer = new System.Windows.Forms.PictureBox();
            this.attachImageButtonAnswer = new System.Windows.Forms.Button();
            this.questionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuestion)).BeginInit();
            this.splitContainerQuestion.Panel1.SuspendLayout();
            this.splitContainerQuestion.Panel2.SuspendLayout();
            this.splitContainerQuestion.SuspendLayout();
            this.tableLayoutPanelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageThumbnailQuestion)).BeginInit();
            this.formattingBox.SuspendLayout();
            this.textHighlightBox.SuspendLayout();
            this.colourBox.SuspendLayout();
            this.acknowledgementsBox.SuspendLayout();
            this.answerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnswer)).BeginInit();
            this.splitContainerAnswer.Panel1.SuspendLayout();
            this.splitContainerAnswer.Panel2.SuspendLayout();
            this.splitContainerAnswer.SuspendLayout();
            this.tableLayoutPanelAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageThumbnailAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.splitContainerQuestion);
            this.questionBox.Location = new System.Drawing.Point(12, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(549, 277);
            this.questionBox.TabIndex = 1;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Question";
            // 
            // splitContainerQuestion
            // 
            this.splitContainerQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQuestion.Location = new System.Drawing.Point(3, 16);
            this.splitContainerQuestion.Name = "splitContainerQuestion";
            this.splitContainerQuestion.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerQuestion.Panel1
            // 
            this.splitContainerQuestion.Panel1.Controls.Add(this.questionText);
            // 
            // splitContainerQuestion.Panel2
            // 
            this.splitContainerQuestion.Panel2.Controls.Add(this.tableLayoutPanelQuestion);
            this.splitContainerQuestion.Size = new System.Drawing.Size(543, 258);
            this.splitContainerQuestion.SplitterDistance = 158;
            this.splitContainerQuestion.TabIndex = 2;
            // 
            // questionText
            // 
            this.questionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionText.Location = new System.Drawing.Point(0, 0);
            this.questionText.MinimumSize = new System.Drawing.Size(4, 20);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(543, 158);
            this.questionText.TabIndex = 1;
            this.questionText.Text = "";
            this.questionText.Enter += new System.EventHandler(this.changeFocusedBox);
            // 
            // tableLayoutPanelQuestion
            // 
            this.tableLayoutPanelQuestion.ColumnCount = 3;
            this.tableLayoutPanelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelQuestion.Controls.Add(this.imageThumbnailQuestion, 1, 0);
            this.tableLayoutPanelQuestion.Controls.Add(this.attachImageButtonQuestion, 2, 0);
            this.tableLayoutPanelQuestion.Controls.Add(this.imageLabelQuestion, 0, 0);
            this.tableLayoutPanelQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelQuestion.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelQuestion.Name = "tableLayoutPanelQuestion";
            this.tableLayoutPanelQuestion.RowCount = 1;
            this.tableLayoutPanelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuestion.Size = new System.Drawing.Size(543, 96);
            this.tableLayoutPanelQuestion.TabIndex = 9;
            // 
            // imageLabelQuestion
            // 
            this.imageLabelQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabelQuestion.AutoSize = true;
            this.imageLabelQuestion.Location = new System.Drawing.Point(3, 41);
            this.imageLabelQuestion.Name = "imageLabelQuestion";
            this.imageLabelQuestion.Size = new System.Drawing.Size(39, 13);
            this.imageLabelQuestion.TabIndex = 0;
            this.imageLabelQuestion.Text = "Image:";
            // 
            // imageThumbnailQuestion
            // 
            this.imageThumbnailQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageThumbnailQuestion.Location = new System.Drawing.Point(48, 3);
            this.imageThumbnailQuestion.Name = "imageThumbnailQuestion";
            this.imageThumbnailQuestion.Size = new System.Drawing.Size(90, 90);
            this.imageThumbnailQuestion.TabIndex = 1;
            this.imageThumbnailQuestion.TabStop = false;
            this.imageThumbnailQuestion.Click += new System.EventHandler(this.imageThumbnail_Click);
            // 
            // attachImageButtonQuestion
            // 
            this.attachImageButtonQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attachImageButtonQuestion.Location = new System.Drawing.Point(144, 36);
            this.attachImageButtonQuestion.Name = "attachImageButtonQuestion";
            this.attachImageButtonQuestion.Size = new System.Drawing.Size(97, 23);
            this.attachImageButtonQuestion.TabIndex = 2;
            this.attachImageButtonQuestion.Text = "Attach Image...";
            this.attachImageButtonQuestion.UseVisualStyleBackColor = true;
            this.attachImageButtonQuestion.Click += new System.EventHandler(this.attachImageButton_Click);
            // 
            // formattingBox
            // 
            this.formattingBox.Controls.Add(this.underlineButton);
            this.formattingBox.Controls.Add(this.italicsButton);
            this.formattingBox.Controls.Add(this.boldButton);
            this.formattingBox.Controls.Add(this.textHighlightBox);
            this.formattingBox.Controls.Add(this.colourBox);
            this.formattingBox.Location = new System.Drawing.Point(567, 12);
            this.formattingBox.Name = "formattingBox";
            this.formattingBox.Size = new System.Drawing.Size(247, 607);
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
            // boldButton
            // 
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Location = new System.Drawing.Point(6, 16);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(75, 23);
            this.boldButton.TabIndex = 8;
            this.boldButton.Text = "Bold";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
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
            this.saveButton.Location = new System.Drawing.Point(12, 625);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 625);
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
            this.acknowledgementsBox.Location = new System.Drawing.Point(15, 578);
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
            // imageDialog
            // 
            this.imageDialog.Filter = "\"Image files (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif\"";
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.splitContainerAnswer);
            this.answerBox.Location = new System.Drawing.Point(15, 295);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(549, 277);
            this.answerBox.TabIndex = 9;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Answer";
            // 
            // splitContainerAnswer
            // 
            this.splitContainerAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAnswer.Location = new System.Drawing.Point(3, 16);
            this.splitContainerAnswer.Name = "splitContainerAnswer";
            this.splitContainerAnswer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAnswer.Panel1
            // 
            this.splitContainerAnswer.Panel1.Controls.Add(this.answerText);
            // 
            // splitContainerAnswer.Panel2
            // 
            this.splitContainerAnswer.Panel2.Controls.Add(this.tableLayoutPanelAnswer);
            this.splitContainerAnswer.Size = new System.Drawing.Size(543, 258);
            this.splitContainerAnswer.SplitterDistance = 158;
            this.splitContainerAnswer.TabIndex = 2;
            // 
            // answerText
            // 
            this.answerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerText.Location = new System.Drawing.Point(0, 0);
            this.answerText.MinimumSize = new System.Drawing.Size(4, 20);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(543, 158);
            this.answerText.TabIndex = 1;
            this.answerText.Text = "";
            // 
            // tableLayoutPanelAnswer
            // 
            this.tableLayoutPanelAnswer.ColumnCount = 3;
            this.tableLayoutPanelAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAnswer.Controls.Add(this.imageLabelAnswer, 0, 0);
            this.tableLayoutPanelAnswer.Controls.Add(this.imageThumbnailAnswer, 1, 0);
            this.tableLayoutPanelAnswer.Controls.Add(this.attachImageButtonAnswer, 2, 0);
            this.tableLayoutPanelAnswer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelAnswer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAnswer.Name = "tableLayoutPanelAnswer";
            this.tableLayoutPanelAnswer.RowCount = 1;
            this.tableLayoutPanelAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAnswer.Size = new System.Drawing.Size(543, 96);
            this.tableLayoutPanelAnswer.TabIndex = 9;
            // 
            // imageLabelAnswer
            // 
            this.imageLabelAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLabelAnswer.AutoSize = true;
            this.imageLabelAnswer.Location = new System.Drawing.Point(3, 41);
            this.imageLabelAnswer.Name = "imageLabelAnswer";
            this.imageLabelAnswer.Size = new System.Drawing.Size(39, 13);
            this.imageLabelAnswer.TabIndex = 0;
            this.imageLabelAnswer.Text = "Image:";
            // 
            // imageThumbnailAnswer
            // 
            this.imageThumbnailAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageThumbnailAnswer.Location = new System.Drawing.Point(48, 3);
            this.imageThumbnailAnswer.Name = "imageThumbnailAnswer";
            this.imageThumbnailAnswer.Size = new System.Drawing.Size(90, 90);
            this.imageThumbnailAnswer.TabIndex = 1;
            this.imageThumbnailAnswer.TabStop = false;
            this.imageThumbnailAnswer.Click += new System.EventHandler(this.imageThumbnail_Click);
            // 
            // attachImageButtonAnswer
            // 
            this.attachImageButtonAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attachImageButtonAnswer.Location = new System.Drawing.Point(144, 36);
            this.attachImageButtonAnswer.Name = "attachImageButtonAnswer";
            this.attachImageButtonAnswer.Size = new System.Drawing.Size(97, 23);
            this.attachImageButtonAnswer.TabIndex = 2;
            this.attachImageButtonAnswer.Text = "Attach Image...";
            this.attachImageButtonAnswer.UseVisualStyleBackColor = true;
            this.attachImageButtonAnswer.Click += new System.EventHandler(this.attachImageButton_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 662);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.acknowledgementsBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.formattingBox);
            this.Controls.Add(this.questionBox);
            this.KeyPreview = true;
            this.Name = "AddQuestion";
            this.Text = "Add a Question";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddQuestion_KeyDown);
            this.questionBox.ResumeLayout(false);
            this.splitContainerQuestion.Panel1.ResumeLayout(false);
            this.splitContainerQuestion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuestion)).EndInit();
            this.splitContainerQuestion.ResumeLayout(false);
            this.tableLayoutPanelQuestion.ResumeLayout(false);
            this.tableLayoutPanelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageThumbnailQuestion)).EndInit();
            this.formattingBox.ResumeLayout(false);
            this.textHighlightBox.ResumeLayout(false);
            this.textHighlightBox.PerformLayout();
            this.colourBox.ResumeLayout(false);
            this.acknowledgementsBox.ResumeLayout(false);
            this.answerBox.ResumeLayout(false);
            this.splitContainerAnswer.Panel1.ResumeLayout(false);
            this.splitContainerAnswer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnswer)).EndInit();
            this.splitContainerAnswer.ResumeLayout(false);
            this.tableLayoutPanelAnswer.ResumeLayout(false);
            this.tableLayoutPanelAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageThumbnailAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.RichTextBox questionText;
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
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button whiteColourButton;
        private System.Windows.Forms.SplitContainer splitContainerQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuestion;
        private System.Windows.Forms.Label imageLabelQuestion;
        private System.Windows.Forms.PictureBox imageThumbnailQuestion;
        private System.Windows.Forms.Button attachImageButtonQuestion;
        private System.Windows.Forms.OpenFileDialog imageDialog;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.SplitContainer splitContainerAnswer;
        private System.Windows.Forms.RichTextBox answerText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAnswer;
        private System.Windows.Forms.Label imageLabelAnswer;
        private System.Windows.Forms.PictureBox imageThumbnailAnswer;
        private System.Windows.Forms.Button attachImageButtonAnswer;
    }
}