using QuenA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuenA
{
    public partial class ViewQuestion : Form
    {
        private bool answerHidden;
        private bool hasAcknowledgements;

        public ViewQuestion(QuestionCard card) {
            Text = card.FlavourText;
            InitializeComponent();
            questionText.Rtf = card.QuestionText;
            answerText.Rtf = card.AnswerText;
            acknowledgmentsText.Rtf = card.AcknowledgementsText;

            hasAcknowledgements = !String.IsNullOrEmpty(acknowledgmentsText.Text);
            if (!hasAcknowledgements) {
                //hide empty (and therefore useless acknowledgements box)
                acknowledgementsBox.Visible = false;
                //'pull up' show/hide button accordingly
                viewAnswerButton.Location = new Point(viewAnswerButton.Location.X, viewAnswerButton.Location.Y - acknowledgementsBox.Height); 
                //resize window to remove resultant white space
                this.Height -= acknowledgementsBox.Height; 
            }

            //wouldn't really make sense if the answer was shown immediately, now would it?
            hideAnswer();
        }

        /// <summary>
        /// This method will be called when the "Show Answer" button is pressed and the answer box is NOT visible in the window (i.e. in its initial state).
        /// It makes the answer box visible and 'pushes down' element supposed to be below it in order to make room.
        /// </summary>
        private void showAnswer() {
            answerBox.Visible = true;

            //moves show/hide button and acknowledgements bar, if existent
            Point newAcknowledgementsLocation = new Point (answerBox.Location.X, (answerBox.Location.Y + answerBox.Size.Height));
            if (hasAcknowledgements)
            {
                acknowledgementsBox.Location = newAcknowledgementsLocation;
                viewAnswerButton.Location = new Point(newAcknowledgementsLocation.X, newAcknowledgementsLocation.Y + acknowledgementsBox.Size.Height);
            }
            else
            {
                viewAnswerButton.Location = newAcknowledgementsLocation;
            }

            //resize window to make room for the shown answer 
            this.Height += answerBox.Size.Height;

            //change text of button
            viewAnswerButton.Text = "Hide Answer";
            //set boolean to the correct value for when clicked again
            answerHidden = false;
        }
    
        /// <summary>
        /// This method will be called when the "Hide Answer" button is clicked and the answer box is visible in the window.
        /// It hides the answer box and 'pulls up' the elements below it to get rid of the resultant white space.
        /// </summary>
        private void hideAnswer() {
            answerBox.Visible = false;

            //move the acknowledgementsbar to the same position as the now hidden answer box
            if (hasAcknowledgements)
            {
                acknowledgementsBox.Location = answerBox.Location;
            }

            //move the "Hide Answer" button so that it 'replaces' the position of the now-hidden answer box.
            Point newButtonLocation = new Point(viewAnswerButton.Location.X, (viewAnswerButton.Location.Y - answerBox.Size.Height));
            viewAnswerButton.Location = newButtonLocation;

            //resize window to eliminate resultant whitespace 
            this.Height -= answerBox.Size.Height;
           
            //change text of the button
            viewAnswerButton.Text = "Show Answer";
            //set boolean for when button is clicked again, the answer is shown
            answerHidden = true;
        }

        /// <summary>
        /// This method will switch between the answer being hidden and not hidden.  See showAnswer() and hideAnswer() methods for more information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewAnswerButton_Click_1(object sender, EventArgs e)
        {
            if (answerHidden)
            {
                showAnswer();
            }
            else
            {
                hideAnswer();
            }
        }
             
    }
}
