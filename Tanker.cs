using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    class Tanker: Sydno
    {
        private int tankerVolumeStorage;
        #region Constructors 
        public Tanker(string name, int speed, int crew, double capacity, int volumeStorage) : base(name, speed, crew, capacity)
        {
            VolumeStorage = volumeStorage;
        }
        #endregion
        #region Methods
        public override void Procces()
        {
            if (VolumeStorage > 0)
                Console.WriteLine("Tanker has liquid cargo");
            else throw new ArgumentException("Tanker hasnt got liquid cargo");
        }
        public override string ToString()
        {
            return base.ToString() + $" Volume Storage:{ tankerVolumeStorage}";
        }
        #endregion
        #region Properties
        public int VolumeStorage
        {
            get { return tankerVolumeStorage; }
            set {
                if (value > 0)
                    tankerVolumeStorage = value;
                else throw new ArgumentException("Wrong tanker value(Volume Storage)"); 
            }
        }
        #endregion
    }
}
