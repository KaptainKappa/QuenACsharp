using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuenA.Data
{
    [Serializable()]
    public class Subject : QuestionCollection
    {
        //The name of the subject (e.g. Chemistry, French History, etc.)
        private string subjectName;
        public string SubjectName { get { return subjectName; } set { subjectName = value; } }

        public Subject() : base(){
            subjectName = "Untitled";
        }

        /// <summary>
        /// Add a QuestionCard to this subject.
        /// </summary>
        /// <param name="card">QuestionCard to add.</param>
        public void addCard(QuestionCard card) {
            cards.Add(card);
        }

        /// <summary>
        /// Remove a card in the subject, if present.
        /// </summary>
        /// <param name="card">Card to remove</param>
        public bool removeCard(QuestionCard card) {
            if (checkForCard(card))  //card is present in the subject
            {
                cards.Remove(card);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check for the presence of a card in tis subject
        /// </summary>
        /// <param name="card">Card to check for</param>
        /// <returns>true if present in the subject, false if not</returns>
        public bool checkForCard(QuestionCard card) {
            return cards.Contains(card);
        }

        /// <summary>
        /// Return the string representations of all question cards in this subject.
        /// </summary>
        public string toString() {
            string output = "";
            foreach (QuestionCard qCard in cards){
                output += qCard.toString();
                output += "\n\n";
            }
            return output;
        }

    }
}
