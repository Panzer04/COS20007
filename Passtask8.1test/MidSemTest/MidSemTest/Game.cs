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
        string _developer;
        public Game(string name, string creator, string rating) : base(name)
        {
            _rating = rating;
            _developer = creator;
        }

        public string Rating
        {
            get
            {
                return _rating;
            }
        }

        public override string Creator
        {
            get
            {
                return _developer;
            }
        }
    }
}
