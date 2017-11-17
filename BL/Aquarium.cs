using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aquarium// : ISubject 
    {
        public ListOfAquaPeople AllFish { get; private set; } = new ListOfAquaPeople();
        public List<Food> Ohapka { get; private set; } = new List<Food>();

        public void Add(LiveInAqua fish)
        {
            AllFish.Add(fish);
        }

        public void CreateFood(int x, int y)
        {
            Ohapka.Add(new Food(x, y));
        }

        public void FallFood()
        {
            foreach (Food foo in Ohapka)
                foreach (Food.Kroshka kr in foo.Korm)
                    kr.Sink();
        }
    }
}
