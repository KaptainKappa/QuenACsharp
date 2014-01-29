using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuenA.Data;
using RedWards.Patterns.Observer;
using QuenA.Data.Control;
using System.IO;

namespace QuenA.ui
{
    /// <summary>
    /// The main window of the application.  From here, one can create new subjects, save/open existing ones, and perform actions relating to the currently loaded subject.
    /// </summary>
    public partial class MainWindow : Form, IObserver
    {    

        //Collection of all cards of the currently loaded subject.
        private Dictionary<string, QuestionCard> cardMap = new Dictionary<string, QuestionCard>();
        public List<string> FlavourTextList
        {
            get
            {
                return new List<string>(cardMap.Keys);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            currentlyLoadedSubjectLabel.Text = "";
            createBlankSubject();     
            //listen for any subject-related actions being performed
            SubjectControl.attach(this);
            questionList.DataSource = FlavourTextList;
            RefreshWindow();

            openFileDialog.Filter = "QuenA Files (*.que) | *.que";
            saveFileDialog.Filter = "QuenA Files (*.que) | *.que";
        }

       
        /// <summary>
        /// Destructor for MainWindow class.  It removes an instance of this class from SubjectControl's list of observers.
        /// </summary>
        ~MainWindow()
        {
            SubjectControl.detach(this);
        }

        /// <summary>
        /// Brings up the window to create a new question card and add it to the current subject.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            new AddQuestion().Show();
        }

        /// <summary>
        /// Brings up a window to edit the selected question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editQuestionButton_Click(object sender, EventArgs e)
        {
            string selectedCard = (string)questionList.SelectedItem;

            if (selectedCard != null) //value of -1 means no question has been selected
            {

                if (cardMap.ContainsKey(selectedCard))
                {
                    QuestionCard selectedQuestion = cardMap[selectedCard];
                    new AddQuestion(selectedQuestion).Show();
                }
            }
            else
            {
                MessageBox.Show("No question has been selected.");
            }

        }

        /// <summary>
        /// Removes the selected question card from the currently loaded subject.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            string selectedCard = (string)questionList.SelectedItem;
            if (selectedCard != null)
            {
                if (MessageBox.Show("This will remove the question card for good.  Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SubjectControl.removeQuestionCard(cardMap[selectedCard]);
                }
            }
            else
            {
                MessageBox.Show("No question has been selected.");
            }
        }

        /// <summary>
        /// Views the question, with the answer hidden until the user clicks a button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewButton_Click(object sender, EventArgs e)
        {
            string selectedItem = (string)questionList.SelectedItem;
            if (selectedItem != null)
            {
                QuestionCard selectedCard = cardMap[selectedItem];
                new ViewQuestion(selectedCard).Show();
            }
            else
            {
                MessageBox.Show("No question has been selected.");
            }
        }

        /// <summary>
        /// Creates a blank subject and makes it the currently loaded subject.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RuntimeData.UnsavedChanges == true)
            {
                if (promptUnsavedChanges())
                {
                    createBlankSubject();
                }
            }
            else
            {
                createBlankSubject();
            }
        }

        /// <summary>
        /// Shows an OpenFileDialog box, and attempts to load the file selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    SubjectControl.loadSubject(openFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// Save the currently loaded subject ot the place where it was saved last.  If a new subject (i.e. hasn't been saved anywhere yet), acts as if the "Save Topic As..." item was clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RuntimeData.CurrentlyLoadedSubjectFilePath == null) {
                saveTopicAsToolStripMenuItem_Click(sender, e);
                return;
            }
                SubjectControl.saveSubject();
        }

        /// <summary>
        /// Show a SaveFileDialog box, and save the currently loaded subject to the file path chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTopicAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                SubjectControl.saveSubject(filePath);
            }
        }

        /// <summary>
        /// If there are unsaved changes, prompts the user to confirm that they wish to quit and lose all unsaved changes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RuntimeData.UnsavedChanges)
            {
                var result = MessageBox.Show("You still have unsaved changes that will be lost.  Quit anyway?", "Confirm Exit",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

                e.Cancel = (result == DialogResult.No);
            }
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //EVENT HANDLERS END HERE.


        /// <summary>
        /// Show the "About" window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAbout(object sender, EventArgs e)
        {
            new About().Show();
        }

        /// <summary>
        /// Load all question cards in the currently loaded subject to be listed.
        /// </summary>
        private void RefreshWindow()
        {
            currentlyLoadedSubjectLabel.Text = RuntimeData.CurrentlyLoadedSubject.SubjectName;

            //force refresh of question list
            questionList.DataSource = null;
            questionList.DataSource = FlavourTextList;
        }

        /// <summary>
        /// Prompt user to confirm continuation after being shown a message box informing the they have unsaved changes.
        /// </summary>
        /// <returns>true if the "Yes" option has been clicked, false for anything else</returns>
        private bool promptUnsavedChanges()
        {
            if (MessageBox.Show("The current project has unsaved changes.  Continue?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Creates a new blank project and sets it as the currently loaded one
        /// </summary>
        private void createBlankSubject()
        {
            //gets rid of all listed question cards, without deleting them from the subject
            cardMap.Clear();
            SubjectControl.newSubject();
        }

        /// <summary>
        /// Provide this object with new data from the runtime data
        /// </summary>
        public void update()
        {
            //set title bar to be the new project
            string subjectPath = RuntimeData.CurrentlyLoadedSubject.SubjectName;
            //split the file path
            string[] splitPath = subjectPath.Split('\\');
            //get the file name and extension
            string fileNameAndExt = splitPath[splitPath.Length - 1];
            //remove extension
            string fileName = fileNameAndExt.Split('.')[0];
            //set file name as title 
            this.Text = fileName;

            if (RuntimeData.UnsavedChanges)
            {
                this.Text += "*";
            }
            this.Text += " - Questions 'n' Answers (0.90 Beta)";

            //update the list of questions in the question box
            RefreshWindow();
        }

        /// <summary>
        /// To be called when a new subject is loaded.  This method update the card map, so that the question cards of the new subject are displayed in the new window.
        /// </summary>
        public void updateSubject()
        {
            cardMap.Clear();
            foreach (QuestionCard qCard in RuntimeData.CurrentlyLoadedSubject.Cards) {
                addToCardMap(qCard);
            }
        }

        /// <summary>
        /// Add a question card to the card map.
        /// </summary>
        /// <param name="card">The question card to add.</param>
        public bool addToCardMap(QuestionCard card)
        {
            if (cardMap.ContainsKey(card.FlavourText))
            {
                if (MessageBox.Show("The same question already exists.  Overwrite?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cardMap.Remove(card.FlavourText);
                    cardMap.Add(card.FlavourText, card);
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else { 
                cardMap.Add(card.FlavourText, card);
                return true;
            }
        }

        /// <summary>
        /// Remove a question card from the card map.
        /// </summary>
        /// <param name="card">The question card to remove.</param>
        /// <returns>true if the card was present and is removed, false otherwise.</returns>
        public bool removeFromCardMap(QuestionCard card)
        {
            if (cardMap.ContainsKey(card.FlavourText))
            {
                cardMap.Remove(card.FlavourText);
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
