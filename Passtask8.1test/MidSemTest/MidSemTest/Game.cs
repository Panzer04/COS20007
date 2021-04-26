using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSemTest
{
    class Game : LibraryResource
    {
        string _rating;
        public Game(string name, string creator, string rating) : base(name, creator)
        {
            _rating = rating;
        }

        string Rating
        {
            get
            {
                return _rating;
            }
        }
    }
}
