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
        //collection of all cards (key is card's flavour text)
        protected Dictionary<string, QuestionCard> cards;
        public List<QuestionCard> Cards
        {
            get
            {
                return new List<QuestionCard>(cards.Values);
            }
        }

        protected Random rng = new Random();

        public QuestionCollection()
        {
            cards = new Dictionary<string, QuestionCard>();
        }

        public QuestionCard getRandomCard()
        {
            return Cards[rng.Next(cards.Count)];
        }

        public QuestionCard getCard(string flavourText) {
            return cards[flavourText];
        }

    }
}
