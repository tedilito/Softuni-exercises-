using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddRemoveCollectio : IAddRemoveCollectonable
    {

        public AddRemoveCollectio()
        {
            list = new List<string>();
        }

        public List<string> list { get; set; }

        public int Add(string element)
        {
            list.Insert(0, element);
            return 0;
        }

        public string Remove(string element)
        {
            string removedElement = list.ElementAt(list.Count - 1);
            list.Remove(removedElement);
            return removedElement;
        }
    }
}
