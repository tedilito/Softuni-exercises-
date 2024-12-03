using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    internal interface IMyListable : IAddRemoveCollectonable
    {
        public List<string> Used { get;}
    }
}
