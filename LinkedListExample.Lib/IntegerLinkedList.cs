using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample.Lib
{
    public class IntegerLinkedList
    {
        private int v;

        public IntegerLinkedList(int v)
        {
            this.v = v;
        }

        public int Count { get; }
        public int Sum { get;  }

        public void Append(int v)
        {
            throw new NotImplementedException();
        }
    }
}
