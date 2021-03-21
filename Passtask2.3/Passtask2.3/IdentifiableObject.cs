using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents) //constructor
        {
            foreach(string s in idents)
            {
                _identifiers.Add(s.ToLower()); //ToLower to match AddIdentifier definition
            }
        }

        public string FirstID
        {
            get
            {
                return _identifiers.First();
            }
        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower()); //ToLower due to test definition
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
        
    }
}
