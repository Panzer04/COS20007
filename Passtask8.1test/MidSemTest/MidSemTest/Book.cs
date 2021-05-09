using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSemTest
{
    class Book : LibraryResource
    {
        string _isbn;
        public Book(string name, string creator, string isbn) : base (name, creator)
        {
            _isbn = isbn;
        }

        string ISBN
        {
            get
            {
                return _isbn;
            }
        }
    }
}
