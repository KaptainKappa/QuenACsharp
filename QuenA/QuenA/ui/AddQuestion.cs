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
    /// <summary>
    /// This form will show if a question card is to be added or edited.  It contains three RichTextBox instances - one for the "question", one for the "answer", and one (optional) for any acknowledgements, such as references.
    /// </summary>
    public partial class AddQuestion : Form
    {
        //Whether an existing question is being edited or not.
        private QuestionCard editingQuestion;

        //The last box that had input focus.
        private RichTextBox lastFocusedBox;

        //The full-size image to be attached to the question.
        private Image questionImageFull = null;

        //The full-size image to be attached to the question.
        private Image answerImageFull = null;

        //Create a new AddQuestion box with blank text fields, i.e. creating a new question card.
        public AddQuestion()
        {
            InitializeComponent();
            editingQuestion = null;
        }

        //Create a new AddQuestion box with text field equal to the question card passed as parameter, i.e. editing an existing card
        public AddQuestion(QuestionCard card)
        {
            InitializeComponent();
            questionText.Rtf = card.QuestionText;
            answerText.Rtf = card.AnswerText;
            acknowledgmentsText.Rtf = card.AcknowledgementsText;
            questionImageFull = card.QuestionImage;
            answerImageFull = card.AnswerImage;
            editingQuestion = card;
            setPreviewImage(attachImageButtonQuestion);
            setPreviewImage(attachImageButtonAnswer);
        }

        /// <summary>
        /// Toggles the Bold attribute for the selected text in the last focused text box.
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void boldButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Prompts the user to open an image file and then attaches the image to the question or answer, depending on which button was clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void attachImageButton_Click(object sender, EventArgs e)
        {
            if (imageDialog.ShowDialog() == DialogResult.OK) 
            {
                if (sender == attachImageButtonQuestion) 
                {
                    questionImageFull = Image.FromFile(imageDialog.FileName);
                }
                else if (sender == attachImageButtonAnswer)
                {
                    answerImageFull = Image.FromFile(imageDialog.FileName);
                }

                //put image thumbnail preview in the form
                setPreviewImage(sender as Button);

            }
        }

        /// <summary>
        /// Support for shortcut keys within the text boxes.  If a key combination is pressed (CTRL + B, etc), get what keys are pressed and simulates the clicking of a button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            //check for control key being pressed
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    //CTRL + B - Bold
                    case Keys.B:
                        boldButton_Click(boldButton, e);
                        break;
                    //CTRL + I - Italics
                    case Keys.I:
                        italicsButton_Click(italicsButton, e);
                        //suppress the default behaviour of CTRL+I (inserting a TAB)
                        e.SuppressKeyPress = true;
                        break;
                    //CTRL + U - Underline
                    case Keys.U:
                        underlineButton_Click(underlineButton, e);
                        break;
                }
            }
        }

        /// <summary>
        /// Shows the full-size version of the image thumbnail clicked.
        /// </summary>
        /// <param name="sender">The image thumbnail clicked.</param>
        /// <param name="e"></param>
        private void imageThumbnailQuestion_Click(object sender, EventArgs e)
        {
            if (sender == imageThumbnailQuestion)
            {
                new ImageViewer(questionImageFull).Show();
            }
            else if (sender == imageThumbnailAnswer)
            {
                new ImageViewer(answerImageFull).Show();
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
            if (senderBox != null)
            {
                lastFocusedBox = senderBox;
            }
        }

        /// <summary>
        /// Change the font style of the selected text of the last focused text box to the style specifed, or back to default if already in the style specified.
        /// </summary>
        /// <param name="textBox">RichTextBox that the change will take place in.</param>
        /// <param name="style">Style attribute to change to (bold, italics, underline)</param>
        private void changeFontStyle(RichTextBox textBox, FontStyle style)
        {
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

        /// <summary>
        /// Change the colour of the selected text in the text box passed as parameter.
        /// </summary>
        /// <param name="textBox">The text box contain the text to be recoloured.</param>
        /// <param name="newColour">The colour that the selected text shall be.</param>
        private void changeTextColour(RichTextBox textBox, Color newColour)
        {
            if (textBox != null)
            {
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

        /// <summary>
        /// Change the colour of the highlight of the selected text in the text box passed as parameter.
        /// </summary>
        /// <param name="textBox">The text box contain the text to be recoloured.</param>
        /// <param name="newColour">The colour that the selected text highlight shall be.</param>
        private void changeHighlightColour(RichTextBox textBox, Color newColour)
        {
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
        private void addNewQuestion()
        {

            Debug.Assert(editingQuestion == null); //confirm that user wants to add a new question and not edit an existing one

            QuestionCard qCard = new QuestionCard(questionText.Rtf, answerText.Rtf, acknowledgmentsText.Rtf, questionImageFull, answerImageFull);
            
            SubjectControl.addQuestionCard(qCard);
            Debug.Assert(RuntimeData.CurrentlyLoadedSubject.checkForCard(qCard)); //confirm card has been added to the subject

        }

        /// <summary>
        /// Finalises the changes for the question being edited.
        /// </summary>
        private void editExistingQuestion()
        {

            Debug.Assert(editingQuestion != null); //confirm that user wants to edit an existing question and not add a new one

            QuestionCard outputQuestion = new QuestionCard(editingQuestion);

            outputQuestion.QuestionText = questionText.Rtf;
            outputQuestion.AnswerText = answerText.Rtf;
            outputQuestion.AcknowledgementsText = acknowledgmentsText.Rtf;
            outputQuestion.QuestionImage = questionImageFull;
            outputQuestion.AnswerImage = answerImageFull;

            SubjectControl.changeQuestionCard(editingQuestion, outputQuestion);

            Debug.Assert(!RuntimeData.CurrentlyLoadedSubject.checkForCard(editingQuestion)); //confirm old card has been removed from the subject
            Debug.Assert(RuntimeData.CurrentlyLoadedSubject.checkForCard(outputQuestion)); //confirm new card has been added to the subject

        }

        /// <summary>
        /// Places the thumbnail of the image attached to the question or answer in the thumbnail slot corresponding to it.
        /// </summary>
        /// <param name="buttonClicked"></param>
        private void setPreviewImage(Button buttonClicked)
        {
            if (buttonClicked != null)
            {
                Image thumbnailImage;

                if (buttonClicked == attachImageButtonQuestion)
                {
                    thumbnailImage = questionImageFull;
                    if (thumbnailImage.Width > 100 || thumbnailImage.Height > 100)
                    {
                        thumbnailImage = resizeImageToThumbnail(thumbnailImage);
                    }
                    imageThumbnailQuestion.Size = thumbnailImage.Size;
                    imageThumbnailQuestion.Image = thumbnailImage;
                }
                else if (buttonClicked == attachImageButtonAnswer)
                {
                    thumbnailImage = answerImageFull;
                    if (thumbnailImage.Width > 100 || thumbnailImage.Height > 100)
                    {
                        thumbnailImage = resizeImageToThumbnail(thumbnailImage);
                    }
                    imageThumbnailAnswer.Size = thumbnailImage.Size;
                    imageThumbnailAnswer.Image = thumbnailImage;
                }
            }
        }

        /// <summary>
        /// Resizes an image to the size that fits in a thumbnail slot in the form.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <returns></returns>
        private Image resizeImageToThumbnail(Image image)
        {
            int longestSide = Math.Max(image.Width, image.Height);
            int resizedWidth = (100 * image.Width) / longestSide;
            int resizedHeight = (100 * image.Height) / longestSide;

            Image resizedThumbnail = new Bitmap(resizedWidth, resizedHeight);
            Graphics.FromImage(resizedThumbnail).DrawImage(image, 0, 0, resizedWidth, resizedHeight);
            return resizedThumbnail;
        }

        
        
    }
}
