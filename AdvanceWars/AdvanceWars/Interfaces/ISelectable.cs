using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWars
{
    public interface ISelectable
    {
        bool Selected { get; set; }
        public bool Select() { return false; }

    }
}
