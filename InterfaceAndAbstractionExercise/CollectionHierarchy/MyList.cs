using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class MyList : IMyListable
    {
        public MyList()
        {
            Used = new List<string>();
            list = new List<string>();

        }
        public List<string> Used
        {
            get { return list; }
            private set { }
        }

        public List<string> list { get; private set; }
        public int Add(string element)
        {
            list.Insert(0, element);
            return 0;
        }

        public string Remove(string element)
        {
            string removedElement = list[0];
            list.RemoveAt(0);
            return removedElement;
        }
    }
}
