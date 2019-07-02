using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Document

    {
        private List<Page> _pages = new List<Page>();

        // Constructor llama a el  abstract Factory metodo

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Metodo

        public abstract void CreatePages();
    }
}
