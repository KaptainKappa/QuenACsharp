using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuenA.Data
{
    class CompositeSubject : QuestionCollection
    {

        private HashSet<Subject> subjects;

        public CompositeSubject() : base() {
            subjects = new HashSet<Subject>();
        }

        public void addSubject(Subject subject) {
            if (!subjects.Contains(subject)) {
                foreach (QuestionCard c in subject.Cards){
                    cards.Add(c.FlavourText, c);
                }
                subjects.Add(subject);
            }
        }

        public void removeSubject(Subject subject) {
            if (subjects.Contains(subject)) {
                foreach (QuestionCard c in cards.Values) {
                    if (checkForPresence(subject, c)) {
                        cards.Remove(c.FlavourText);
                    }
                }
                subjects.Remove(subject);
            }
        }

        private bool checkForPresence(Subject s, QuestionCard c) {
            return s.checkForCard(c);
        }



    }
}
