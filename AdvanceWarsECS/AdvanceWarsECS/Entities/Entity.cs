using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWarsECS
{
    class Entity
    {
        List<Component> _components;
        public Entity(){
            _components = new List<Component>();
        }

        public void AddComponent<T>(Component component)
        {
            _components.Add(component);
        }

        public Component Component
        {
            get
            {
                return _components.First();
            }
        }
    }
}
