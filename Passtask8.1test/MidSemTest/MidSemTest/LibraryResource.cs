using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSemTest
{
    class LibraryResource
    {
        string _name;
        string _creator;
        bool _onLoan;
        public LibraryResource(string name, string creator)
        {
            _name = name;
            _creator = creator;
        }



        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Creator
        {
            get
            {
                return _creator;
            }
        }

        public bool OnLoan
        {
            get
            {
                return _onLoan;
            }
            set
            {
                _onLoan = value;
            }
        }

    }
}
