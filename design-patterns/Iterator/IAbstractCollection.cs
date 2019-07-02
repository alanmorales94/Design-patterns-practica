using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
