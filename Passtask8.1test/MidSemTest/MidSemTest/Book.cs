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
        string _author;
        public Book(string name, string creator, string isbn) : base (name)
        {
            _isbn = isbn;
            _author = creator;
        }

        public string ISBN
        {
            get
            {
                return _isbn;
            }
        }

        public override string Creator
        {
            get
            {
                return _author;
            }
        }
    }
}
