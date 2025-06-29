using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    class Refrigerator: Sydno
    {
        private int refrigeratorRefrigeratorTemperature;
        #region Constructors 
        public Refrigerator(string name, int speed, int crew, double capacity, int refrigeratorTemperature) : base(name, speed, crew, capacity)
        {
            RefrigeratorTemperature = refrigeratorTemperature;
        }
        #endregion
        #region Methods
        public override void Procces()
        {
            if (RefrigeratorTemperature > -30 || RefrigeratorTemperature < -12)
                Console.WriteLine("Refrigerator working good");
            else throw new ArgumentException("Refrigerator isnt working");
        }
        public override string ToString()
        {
            return base.ToString() + $" Refrigerator Temperature:{refrigeratorRefrigeratorTemperature}";
        }
        #endregion
        #region Properties
        public int RefrigeratorTemperature
        {
            get { return refrigeratorRefrigeratorTemperature; }
            set{ refrigeratorRefrigeratorTemperature = value; }
        }
        #endregion
    }
}
