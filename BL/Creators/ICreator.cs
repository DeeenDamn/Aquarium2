using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public interface ICreator
    {
        void Create(Graphics g, int x, int y);
    }
}
