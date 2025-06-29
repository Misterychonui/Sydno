using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    public class Comparer : IComparer<Sydno>
    {      
        int IComparer<Sydno>.Compare(Sydno x, Sydno y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }
}
