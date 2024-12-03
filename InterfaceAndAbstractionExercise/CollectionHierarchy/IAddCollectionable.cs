using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public interface IAddCollectionable
    {
         List<string> list { get;  }
  
        int Add(string element);
    }
}
