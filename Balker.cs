using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    class Balker : Drycargoship /*Balker.ICloneable<Balker>*/
    {
        private double balkerEmbankmentheight;
        #region Constructors 
        public Balker(string name, int speed, int crew, double capacity, double embankmentheight, int deck) : base(name, speed, crew, capacity, deck)
        {
            Embankmentheight = embankmentheight;
        }
        #endregion
        #region Methods
        //void ICloneable<Balker>.Clone(Balker x) => new Balker(x.Name, x.Speed, x.Crew, x.Capacity, x.Embankmentheight, x.Deck);
        //internal interface ICloneable<Balker>
        //{
        //   void Clone(Balker x);
        //}
        public override void Procces()
        {
            if (Embankmentheight > 0)
                Console.WriteLine("Balker has cargo");
            else throw new ArgumentException("Balker hasnt got cargo");
        }
        public override string ToString()
        {
            return base.ToString() + $" Embankment height:{balkerEmbankmentheight}";
        }
        public override void TakeCargo(double amount)
        {
            Embankmentheight += amount;           
        }
        #endregion
        #region Properties
        public double Embankmentheight
        {
            get { return balkerEmbankmentheight; }
            set {
                if (value >0)
                    balkerEmbankmentheight = value;
                else throw new ArgumentException("Wrong balker value(embankment height)");
            }
        }
        #endregion
    }
}
