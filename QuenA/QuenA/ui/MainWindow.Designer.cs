namespace QuenA.ui
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTopicAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.editQuestionButton = new System.Windows.Forms.Button();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentlyLoadedSubjectLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.questionList = new System.Windows.Forms.ListBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTopicToolStripMenuItem,
            this.openTopicToolStripMenuItem,
            this.saveTopicToolStripMenuItem,
            this.saveTopicAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTopicToolStripMenuItem
            // 
            this.newTopicToolStripMenuItem.Name = "newTopicToolStripMenuItem";
            this.newTopicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newTopicToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newTopicToolStripMenuItem.Text = "New Subject";
            this.newTopicToolStripMenuItem.Click += new System.EventHandler(this.newTopicToolStripMenuItem_Click);
            // 
            // openTopicToolStripMenuItem
            // 
            this.openTopicToolStripMenuItem.Name = "openTopicToolStripMenuItem";
            this.openTopicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTopicToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openTopicToolStripMenuItem.Text = "Open Subject";
            this.openTopicToolStripMenuItem.Click += new System.EventHandler(this.openTopicToolStripMenuItem_Click);
            // 
            // saveTopicToolStripMenuItem
            // 
            this.saveTopicToolStripMenuItem.Name = "saveTopicToolStripMenuItem";
            this.saveTopicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTopicToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveTopicToolStripMenuItem.Text = "Save Subject";
            this.saveTopicToolStripMenuItem.Click += new System.EventHandler(this.saveTopicToolStripMenuItem_Click);
            // 
            // saveTopicAsToolStripMenuItem
            // 
            this.saveTopicAsToolStripMenuItem.Name = "saveTopicAsToolStripMenuItem";
            this.saveTopicAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveTopicAsToolStripMenuItem.Text = "Save Subject As...";
            this.saveTopicAsToolStripMenuItem.Click += new System.EventHandler(this.saveTopicAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.showAbout);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(438, 30);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.addQuestionButton.TabIndex = 2;
            this.addQuestionButton.Text = "Add...";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // editQuestionButton
            // 
            this.editQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editQuestionButton.Location = new System.Drawing.Point(438, 89);
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.editQuestionButton.TabIndex = 3;
            this.editQuestionButton.Text = "Edit...";
            this.editQuestionButton.UseVisualStyleBackColor = true;
            this.editQuestionButton.Click += new System.EventHandler(this.editQuestionButton_Click);
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Location = new System.Drawing.Point(438, 118);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.removeQuestionButton.TabIndex = 4;
            this.removeQuestionButton.Text = "Remove";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"Binary Files (*.bin)|*.bin\"";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentlyLoadedSubjectLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(527, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabel1.Text = "Currently Loaded Subject: ";
            // 
            // currentlyLoadedSubjectLabel
            // 
            this.currentlyLoadedSubjectLabel.Name = "currentlyLoadedSubjectLabel";
            this.currentlyLoadedSubjectLabel.Size = new System.Drawing.Size(103, 17);
            this.currentlyLoadedSubjectLabel.Text = "SUBJECT_LOADED";
            // 
            // questionList
            // 
            this.questionList.FormattingEnabled = true;
            this.questionList.Location = new System.Drawing.Point(12, 27);
            this.questionList.Name = "questionList";
            this.questionList.ScrollAlwaysVisible = true;
            this.questionList.Size = new System.Drawing.Size(418, 511);
            this.questionList.TabIndex = 1;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(438, 60);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 6;
            this.viewButton.Text = "View...";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 576);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.editQuestionButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "QuenA - Questions \'n\' Answers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTopicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTopicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button editQuestionButton;
        private System.Windows.Forms.Button removeQuestionButton;
        private System.Windows.Forms.ToolStripMenuItem saveTopicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTopicAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel currentlyLoadedSubjectLabel;
        private System.Windows.Forms.ListBox questionList;
        private System.Windows.Forms.Button viewButton;
    }
}