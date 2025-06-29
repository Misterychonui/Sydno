using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    class Drycargoship: Sydno
    {
        private int drycargoshipDeck;
        #region Constructors 
        public Drycargoship(string name, int speed, int crew, double capacity, int deck): base(name,speed,crew,capacity)
        {
            Deck = deck;
        }
        #endregion
        #region Methods
        public override void Procces()
        {
            if (Speed > 0)
                Console.WriteLine("Drycargoship is floats");
            else throw new ArgumentException("Drycargoship isnt floats");
        }
        public override string ToString()
        {
            return base.ToString()+$" Deck:{drycargoshipDeck}";
        }
        #endregion
        #region Properties
        public int Deck
        {
            get { return drycargoshipDeck; }
            set {
                if (value >= 1)
                    drycargoshipDeck = value;
                else throw new ArgumentException("Wrong dry cargo ship value(deck)");
            }
        }        
        #endregion
    }
}
