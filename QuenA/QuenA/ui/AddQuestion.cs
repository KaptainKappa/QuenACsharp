using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using QuenA.Data;
using System.Diagnostics;
using QuenA.Data.Control;


namespace QuenA.ui
{
    public partial class AddQuestion : Form
    {
        //Whether an existing question is being edited or not.
        private QuestionCard editingQuestion; 
        
        //The last box that had input focus.
        private RichTextBox lastFocusedBox;

        public AddQuestion()
        {
            InitializeComponent();
            editingQuestion = null;
           
        }

        public AddQuestion(QuestionCard card) {
            InitializeComponent();
            questionText.Rtf = card.QuestionText;
            answerText.Rtf = card.AnswerText;
            acknowledgmentsText.Rtf = card.AcknowledgementsText;
            editingQuestion = card;
        }

        /// <summary>
        /// Toggles the Bold attribute for the selected text in the last focused text box.
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void boldTextButton_Click(object sender, EventArgs e)
        {
            changeFontStyle(lastFocusedBox, FontStyle.Bold);
        }

        /// <summary>
        /// Toggles the Italics attribute for the selected text in the last focused text box.
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void italicsButton_Click(object sender, EventArgs e)
        {
            changeFontStyle(lastFocusedBox, FontStyle.Italic);
        }

        /// <summary>
        /// Toggles the Underline attribute for the selected text in the last focused text box.
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void underlineButton_Click(object sender, EventArgs e)
        {
            changeFontStyle(lastFocusedBox, FontStyle.Underline);
        }

        /// <summary>
        /// Changes either the text colour or text highlight to the background colour of the button clicked
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void colourButton_Click(object sender, EventArgs e)
        {
            //cast sender object to a Button
            Button senderButton = sender as Button;
            if (senderButton != null)
            {
                if (textColourRadio.Checked)
                {
                    //change text colour to colour represented by sender button
                    changeTextColour(lastFocusedBox, senderButton.BackColor);
                }
                else if (highlightColourRadio.Checked)
                {
                    //change text highlight colour to colour represented by sender button
                    changeHighlightColour(lastFocusedBox, senderButton.BackColor);
                }
            }
        }

        /// <summary>
        /// Changes either the text colour or text highlight to the result of a colour dialog shown when clicking the "Custom..." button 
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void customColourButton_Click(object sender, EventArgs e)
        {
            //check for user pressing "OK"
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (textColourRadio.Checked)
                {
                    //change text colour to colour represented by colour dialog result
                    changeTextColour(lastFocusedBox, colorDialog.Color);
                }
                else if (highlightColourRadio.Checked)
                {
                    //change text highlight colour to colour represented by colour dialog result
                    changeHighlightColour(lastFocusedBox, colorDialog.Color);
                }
            }
        }

        /// <summary>
        /// Confirms the new question and adds/edits it, and closes this window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editingQuestion == null)
            {
                addNewQuestion();
            }
            else
            {
                editExistingQuestion();
            }
            this.Dispose();
        }

        /// <summary>
        /// Discards all changes to the question being created/editing, and closes this window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //ask user for confirmation
            if (MessageBox.Show("Are you sure you wish to cancel?  You will lose all changes made.", "Confirm cancel", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }





        //EVENT HANDLERS END HERE.







       

        /// <summary>
        /// This method will be called whenever a RichTextBox (and only a RichTextBox) enters input focus.  
        /// It changes the lastFocusedBox attribute to the event sender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeFocusedBox(object sender, EventArgs e) 
        {
            //cast the sender to a RichTextBox
            RichTextBox senderBox = sender as RichTextBox;
            if (senderBox != null){
                lastFocusedBox = senderBox;
            }
        }

        /// <summary>
        /// Change the font style of the selected text of the last focused text box to the style specifed, or back to default if already in the style specified.
        /// </summary>
        /// <param name="textBox">RichTextBox that the change will take place in.</param>
        /// <param name="style">Style attribute to change to (bold, italics, underline)</param>
        private void changeFontStyle(RichTextBox textBox, FontStyle style) {
            if (textBox != null)
            {
                //check that text acutally has been selected
                if (textBox.SelectionLength > 0)
                {
                    //save the selection start and length for later recall
                    int initSelectStart = textBox.SelectionStart;
                    int initSelectLength = textBox.SelectionLength;

                    if (textBox.SelectionFont.Style != style)
                    {
                        //change the selected font to passed style
                        textBox.SelectionFont = new Font(textBox.Font, style);
                        //go the the end of the selection and make it so any future characters typed have default formatting (i.e. not bold)
                        textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
                        textBox.SelectionLength = 0;
                        textBox.SelectionFont = textBox.Font;
                    }
                    else
                    {
                        //revert to regular formatting
                        textBox.SelectionFont = textBox.Font;
                    }
                    //recall initial selection
                    textBox.Select(initSelectStart, initSelectLength);
                }
                else
                {
                    if (textBox.SelectionFont.Style != style)
                    {
                        //apply font style
                        textBox.SelectionFont = new Font(textBox.Font, style);
                    }
                    else
                    {
                        //revert to regular formatting
                        textBox.SelectionFont = textBox.Font;
                    }
                }
                //change focus from the font style button to the question box
                textBox.Focus();
            }
        }

        private void changeTextColour(RichTextBox textBox, Color newColour) 
        {
            if (textBox != null) {
                //check that text acutally has been selected
                if (textBox.SelectionLength > 0)
                {
                    //save the selection start and length for later recall
                    int initSelectStart = textBox.SelectionStart;
                    int initSelectLength = textBox.SelectionLength;
                    //change the selected colour to the one passed as parameter
                    textBox.SelectionColor = newColour;
                    //go the the end of the selection and make it so any future characters typed have default colour
                    textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
                    textBox.SelectionLength = 0;
                    textBox.SelectionColor = textBox.ForeColor;
                    //recall initial selection
                    textBox.Select(initSelectStart, initSelectLength);
                }
                else
                {
                    //apply new colour
                    textBox.SelectionColor = newColour;
                }
                //change focus from the colour button to the text box
                textBox.Focus();
            }
        }

        private void changeHighlightColour(RichTextBox textBox, Color newColour) {
            if (textBox != null)
            {
                 //check that text acutally has been selected
                if (textBox.SelectionLength > 0)
                {
                    //save the selection start and length for later recall
                    int initSelectStart = textBox.SelectionStart;
                    int initSelectLength = textBox.SelectionLength;
                    //change the selected colour to the one passed as parameter
                    textBox.SelectionBackColor = newColour;
                    //go the the end of the selection and make it so any future characters typed have default colour
                    textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
                    textBox.SelectionLength = 0;
                    textBox.SelectionBackColor = textBox.BackColor;
                    //recall initial selection
                    textBox.Select(initSelectStart, initSelectLength);
                }
                else
                {
                    //apply new colour
                    textBox.SelectionBackColor = newColour;
                }
                //change focus from the colour button to the text box
                textBox.Focus();
            }
        }

        /// <summary>
        /// Adds the newly created question to the currently loaded subject.
        /// </summary>
        private void addNewQuestion() {

            Debug.Assert(editingQuestion == null); //confirm that user wants to add a new question and not edit an existing one

            QuestionCard qCard;
            if (String.IsNullOrWhiteSpace(acknowledgmentsText.Text))
            {
                qCard = new QuestionCard(questionText.Rtf, answerText.Rtf);
            }
            else
            {
                qCard = new QuestionCard(questionText.Rtf, answerText.Rtf, acknowledgmentsText.Rtf);
            }

            SubjectControl.addQuestionCard(qCard);
            Debug.Assert(RuntimeData.CurrentlyLoadedSubject.checkForCard(qCard)); //confirm card has been added to the subject

        }

        /// <summary>
        /// Finalises the changes for the question being edited.
        /// </summary>
        private void editExistingQuestion() {

            Debug.Assert(editingQuestion != null); //confirm that user wants to edit an existing question and not add a new one

            QuestionCard outputQuestion = new QuestionCard(editingQuestion);

            outputQuestion.QuestionText = questionText.Rtf;
            outputQuestion.AnswerText = answerText.Rtf;
            outputQuestion.AcknowledgementsText = acknowledgmentsText.Rtf;

            SubjectControl.changeQuestionCard(editingQuestion, outputQuestion);

            Debug.Assert(!RuntimeData.CurrentlyLoadedSubject.checkForCard(editingQuestion)); //confirm old card has been removed from the subject
            Debug.Assert(RuntimeData.CurrentlyLoadedSubject.checkForCard(outputQuestion)); //confirm new card has been added to the subject

        }

 
    }
}
