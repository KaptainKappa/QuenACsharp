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
                cards.AddRange(subject.Cards);
                subjects.Add(subject);
            }
        }

        public void removeSubject(Subject subject) {
            if (subjects.Contains(subject)) {
                foreach (QuestionCard c in cards) {
                    if (checkForPresence(subject, c)) {
                        cards.Remove(c);
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
