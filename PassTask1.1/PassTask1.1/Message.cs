using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTask1._1
{
    class Message
    {
        private string _text;
        public Message(string txt) //Constructor, not a method
        {
            _text = txt;
        }

        public void Print()
        {
            Console.WriteLine(_text);
        }
    }
}
