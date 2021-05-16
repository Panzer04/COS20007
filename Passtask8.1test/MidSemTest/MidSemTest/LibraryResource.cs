using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSemTest
{
    abstract class LibraryResource
    {
        string _name;
        bool _onLoan;
        public LibraryResource(string name)
        {
            _name = name;
        }



        public string Name
        {
            get
            {
                return _name;
            }
        }

        abstract public string Creator
        {
            get;
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
