using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollectionable
    {
        public List<string> list {  get; set; }

        public AddCollection()
        {
            this.list = new List<string>();
        }

        public int Add(string element)
        {
            if (list.Count - 1 < 0)
            {
                list.Insert(list.Count, element);
                return 0 ;
            }
            list.Insert(list.Count - 1, element);
            return list.Count - 1;
        }
    }
}
