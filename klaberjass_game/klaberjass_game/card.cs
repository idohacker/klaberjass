using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaberjass_game
{
    public class Card
    {
        private Cardtype type;
        private int val;

        public Card(int val, Cardtype type)
        {
            this.val = val;
            this.type = type;
        }

        public Cardtype Type
        {
            set { type = value; }
            get { return type; }
        }

        public int Val
        {
            set { val = value; }
            get { return val; }
        }
    }
}
