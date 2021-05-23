using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWarsECS
{
    class CDrawable : Component
    {
        public CDrawable(int x, int y, int Drawsize, string texture) { X = x; Y = y; DrawSize = Drawsize; Texture = texture; }

        public int X { get; set; }
        public int Y { get; set; }
        public int DrawSize { get; set; }
        public string Texture { get; set; }
    }
}
