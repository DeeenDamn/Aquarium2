using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class ListOfAquaPeople : LiveInAqua
    {
        public List<LiveInAqua> residents;
        Drawing draw = new Drawing();
        Bitmap bmp;
        Image mainBmp = Image.FromFile("background.png");

        public ListOfAquaPeople()
        {
            residents = new List<LiveInAqua>();
        }

        public void Add(LiveInAqua p)
        {
            residents.Add(p);
        }

        public override void Move()
        {
            if (residents.Count != 0)
            {
                for (int i = 0; i < residents.Count; i++)
                {
                    if (residents.ElementAt(i).health == 0)
                    {
                        residents.ElementAt(i).Die();
                    }
                    else
                    {
                        if (PointNewOrNo(residents.ElementAt(i).X, residents.ElementAt(i).Y, residents.ElementAt(i).TrgX, residents.ElementAt(i).TrgY))
                        {
                            residents.ElementAt(i).SetPoint();
                        }

                        residents.ElementAt(i).Move();
                    }

                }
            }
            //    bmp = draw.DrawAll();
            //}
            //else
            //    bmp = new Bitmap(mainBmp);
        }
        public Bitmap BM()
        {
            return bmp;
        }

        private bool PointNewOrNo(int x, int y, int targetX, int targetY)
        {
            if (Math.Abs(targetX - x) < 6 || Math.Abs(targetY - y) < 3)
                return true;
            else
                return false;
        }

        public void SlowDie()
        {
            foreach (LiveInAqua f in residents)
            {
                if (f.health > 0)
                    f.health -= 1;
            }
        }




        List<LiveInAqua> subscribers = new List<LiveInAqua>();

        public void IsHungry()
        {
            foreach (LiveInAqua fish in residents)
            {
                if (fish is FishAdult || fish is FishChild)
                    subscribers.Add(fish);
            }
        }

        public void RemoveObservers()
        {
            subscribers.Clear();
        }

        public void NotifyObserversFood()
        {
            foreach (LiveInAqua fish in subscribers)
                fish.GoEat();
        }

    }
}
