using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Customer

    {
        private string _name;

        // Constructor

        public Customer(string name)
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
