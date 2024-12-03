using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    internal interface IAddRemoveCollectonable : IAddCollectionable
    {
        string Remove(string element);
    }
}
