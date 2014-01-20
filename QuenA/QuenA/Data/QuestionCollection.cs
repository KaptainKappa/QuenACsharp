using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuenA.Data
{
    [Serializable()]
    public abstract class QuestionCollection
    {
        //collection of all cards
        protected List<QuestionCard> cards;
        public List<QuestionCard> Cards { get { return cards; } }

        protected Random rng = new Random();

        public QuestionCollection(){
            cards = new List<QuestionCard>();
        }

        public QuestionCard getRandomCard()
        {
            return cards[rng.Next(cards.Count)];
        }

    }
}
