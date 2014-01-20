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
    public partial class MainWindow : Form, IObserver
    {
        private static MainWindow instance = new MainWindow();
        public static MainWindow Instance { get { return instance; } }

        //Collection of all card of the currently loaded subject.
        private Dictionary<string, QuestionCard> cardMap = new Dictionary<string, QuestionCard>();
        public List<string> FlavourTextList
        {
            get
            {
                return new List<string>(cardMap.Keys);
            }
        }

        private MainWindow()
        {
            InitializeComponent();
            currentlyLoadedSubjectLabel.Text = "";
            createBlankSubject();
            SubjectControl.attach(this);
            questionList.DataSource = FlavourTextList;
            RefreshWindow();
        }

        /// <summary>
        /// Destructor for MainWindow class.  It removes an instance of this class from SubjectControl's list of observers.
        /// </summary>
        ~MainWindow()
        {
            SubjectControl.detach(this);
        }



        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            new AddQuestion().Show();
        }

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

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            string selectedCard = (string)questionList.SelectedItem;
            if (selectedCard != null)
            {
                SubjectControl.removeQuestionCard(cardMap[selectedCard]);
            }
            else
            {
                MessageBox.Show("No question has been selected.");
            }
        }

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


        private void saveTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RuntimeData.UnsavedChanges == true)
            {
                if (promptUnsavedChanges())
                {
                    SubjectControl.saveSubject();
                }
            }
            else
            {
                SubjectControl.saveSubject();
            }
        }

        private void saveTopicAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                SubjectControl.saveSubject(filePath);
            }
        }

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
            if (MessageBox.Show("The current project has unsaved changes.  Continue?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
            this.Text = RuntimeData.CurrentlyLoadedSubject.SubjectName;
            if (RuntimeData.UnsavedChanges)
            {
                this.Text += "*";
            }
            this.Text += " - Questions 'n' Answers";

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
        public void addToCardMap(QuestionCard card)
        {
            cardMap.Add(card.FlavourText, card);
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
