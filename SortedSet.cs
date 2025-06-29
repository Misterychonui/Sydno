using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sydno
{
    class SortedSet 
    {
        SortedSet<Sydno> sydno;
        public SortedSet()
        {
            sydno = new SortedSet<Sydno>();
        }
        public void Add(Sydno s)
        {
            sydno.Add(s);
        }
        public void Remove(Sydno s)
        {
            sydno.Remove(s);             
        }
        public void Clear()
        {
            sydno.Clear();
        }
        public void Contains(Sydno s)
        {
            if (sydno.Contains(s))
            {
                Console.WriteLine("{0} содержится", s.Name);
            }
        }
        public void PrintInfo()
        {
            foreach (var s in sydno)
            {
                Console.WriteLine(s);
            }
        }
        public void Count()
        {
            sydno.Count();
        }
        public void First(Sydno s)
        {
            sydno.First();
        }
        public void Last(Sydno s)
        {
            sydno.Last();        
        }
    }
}
