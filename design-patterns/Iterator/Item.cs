using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Item

    {
        private string _name;

        // Constructor

        public Item(string name)
        {
            this._name = name;
        }

        // Obtiene el nombre

        public string Name
        {
            get { return _name; }
        }
    }

}

