﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public abstract class Fish : LiveInAqua
    {

        public void Create()
        {
            creator.Create(g, x, y);
        }
      
    }
}