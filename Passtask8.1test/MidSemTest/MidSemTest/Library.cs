using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSemTest
{
    class Library
    {
        List<LibraryResource> _resources = new List<LibraryResource>();
        public Library(string name)
        {

        }

        public void AddResource(LibraryResource resource)
        {
            _resources.Add(resource);
        }

        public bool HasResource(string name)
        {
            foreach(LibraryResource resource in _resources)
            {
                if(resource.Name == name)
                {
                    if (!resource.OnLoan)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
