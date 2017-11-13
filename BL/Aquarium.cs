using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aquarium : LiveInAqua
    {
        public int WorldWidth { get; set; }
        public int WorldHeight { get; set; }

        public int BottomHeight { get; set; }


        public bool Light { get; set; } // включен или выключен свет
        public double Temperature { get; set; } // текущая температура
        public double MinGoodTemperature { get; set; } // минимальная хорошая
        public double MaxGoodTemperature { get; set; } // максимальная хорошая
        public bool ComfortTemperature // является ли температура воды хорошей, влияет на аппетит рыб и активность
        {
            get
            {
                return Temperature >= MinGoodTemperature && Temperature <= MaxGoodTemperature;
            }
        }


    }
}
