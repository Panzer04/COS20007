using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWarsECS
{
    class Tank : Entity
    {
        public Tank()
        {
            CDrawable tank = new CDrawable(50, 50, 10, "tank");
            base.AddComponent<CDrawable>(tank);
        }
    }
}
