using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    [Serializable]
    public class CrewException : Exception
    {
        public CrewException() { }
        public CrewException(string message) : base(message) { }
        public CrewException Errorcrew { get; set; }
        protected CrewException(string message,
            CrewException crew):base(message)
        {
            Errorcrew = crew;
        }         
    }
}
