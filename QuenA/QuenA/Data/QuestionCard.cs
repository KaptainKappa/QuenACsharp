using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuenA.Data
{
    [Serializable()]
    public class QuestionCard
    {

        //date that the question was created
        private DateTime dateCreated;
        public DateTime DateCreated { get { return dateCreated; } }

        //date that the question was last edited
        private DateTime dateLastEdited;
        public DateTime DateLastEdited { get { return dateLastEdited; } }

        //An (invisible) RichTextBox for changing RTF to plain text (see: FlavourText property).
        private static System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();



        //string that separates fields when card is outputted as a string
        private static string fieldSeparator = "/|/|/| \n"; //must be a string that should never come up in normal usage of the program
        public static string FIELD_SEPARATOR { get { return fieldSeparator; } }

        //Text to go in the Question box
        private string questionText;
        public string QuestionText
        {
            get
            {
                return questionText;
            }
            set
            {
                //set text when viewing the question as a whole
                questionText = value;
                updateEditDate();
            }
        }

        //Text to go in the Answer box
        private string answerText;
        public string AnswerText
        {
            get
            {
                return answerText;
            }
            set
            {
                answerText = value;
                updateEditDate();
            }
        }

        //Text to go in the Acknowledgements bar
        private string acknowledgementsText;
        public string AcknowledgementsText
        {
            get
            {
                return acknowledgementsText;
            }
            set
            {
                acknowledgementsText = value;
                updateEditDate();
            }
        }


        //preview text for the question when in the main window
        public string FlavourText
        {
            get
            {
                //set maximum number of characters for converting the question text to flavour text, before it is truncated
                const int MAX_FLAVOUR_TEXT_LENGTH = 50;

                //get formatted text from question text
                string flavourTextRTF = questionText;
                //puts RTF-formatted text into the text box
                rtBox.Rtf = flavourTextRTF;
                //converts to plain text
                string plainText = rtBox.Text;
                string truncPlainText;

                if (plainText.Length <= MAX_FLAVOUR_TEXT_LENGTH)
                {
                    //output string as-is
                    truncPlainText = plainText;
                }
                else
                {
                    //truncate length to 20 characters plus ellipses
                    truncPlainText = plainText.Substring(0, MAX_FLAVOUR_TEXT_LENGTH - 1) + "...";
                }

                return truncPlainText;
            }
        }

        /// <summary>
        /// Construct a QuestionCard identical to the one passed as parameter.
        /// </summary>
        /// <param name="card"></param>
        public QuestionCard(QuestionCard card) : this(card.questionText, card.answerText, card.acknowledgementsText){
            
        }

        /// <summary>
        /// Construct a question card without acknowledgements.
        /// </summary>
        /// <param name="question">Text to go in the Question box when this card is viewed.</param>
        /// <param name="answer">Text to go in the Answer box when this card is viewed.</param>
        public QuestionCard(string question, string answer)
        {
            initialiseText(question, answer, null);
        }


        /// <summary>
        /// Construct a question card with acknowledgements.
        /// </summary>
        /// <param name="question">Text to go in the Question box when this card is viewed.</param>
        /// <param name="answer">Text to go in the Answer box when this card is viewed.</param>
        /// <param name="acknowledgements">Text to go in the Acknowledgements box when this card is viewed.</param>
        public QuestionCard(string question, string answer, string acknowledgements)
        {
            initialiseText(question, answer, acknowledgements);
        }

        /// <summary>
        /// Initialise all text of the question card.  This method is only to be called when a new object is created.
        /// </summary>
        /// <param name="question">Text to go in the Question box when this card is viewed.</param>
        /// <param name="answer">Text to go in the Answer box when this card is viewed.</param>
        /// <param name="acknowledgements">Text to go in the Acknowledgements box when this card is viewed.</param>
        private void initialiseText(string question, string answer, string acknowledgements)
        {
            questionText = question;
            answerText = answer;
            acknowledgementsText = acknowledgements;
            dateCreated = DateTime.Today;
            dateLastEdited = dateCreated;
        }

        /// <summary>
        /// Updates the dateLastEdited field to the current date.
        /// </summary>
        private void updateEditDate()
        {
            dateLastEdited = DateTime.Today;
        }

        /// <summary>
        /// Generate and return a string representation of this object.
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            string output = "";

            //add date created to string
            output += dateCreated.ToShortDateString() + "\n";
            //separate date created and date last separated
            output += FIELD_SEPARATOR;
            //add date last edited to string
            output += dateLastEdited.ToShortDateString() + "\n";
            //separate date last edited and question text
            output += FIELD_SEPARATOR;
            //add question text
            output += questionText + "\n";
            //separate question text and answer text
            output += FIELD_SEPARATOR;
            //add answer text
            output += answerText + "\n";
            //separate answer text and acknowledgements 
            output += FIELD_SEPARATOR;
            //add acknowledgement text
            output += acknowledgementsText + "\n";

            //return completed string
            return output;


        }

    }
}
