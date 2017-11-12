using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListOfAquaPeople : LiveInAqua
    {
        public List<LiveInAqua> residents;
        public ListOfAquaPeople()
        {
            residents = new List<LiveInAqua>();
        }

        public void Add(LiveInAqua p)
        {
            residents.Add(p);
        }
    }
}
