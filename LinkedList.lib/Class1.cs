
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample.Lib
{
    public class IntegerLinkedList
    {

        IntegerNode _head;
        

        public IntegerLinkedList()
        {
        }

        IntegerNode _next;


        public IntegerLinkedList(int n)
        {
            _head = new IntegerNode(n);
        }

        public int Count { 
            get
            {
                if (_head == null)
                    return 0;
                else
                {
                    return _head.Count;
                }
            }
                }
        public int Sum
        {
            get
            {
                if (_head == null)
                    return 0;
                else
                {
                    return _head.Sum;
                }
            }
        }

        public void Append(int v)
        {
            if (_head == null)
                _head = new IntegerNode(v);
            else
            {
                _head.Append(v);
            }
        }

        public override string ToString()
        {
            return $"{{{(_head == null ? string.Empty : _head.ToString())}";
        }
        public bool Delete(int doomed)
        {
            if (_head == null)
                return false;
            if (_head.Value == doomed)
            {
                _head = _head.Next;
                return true;
            }
            return _head.Delete(doomed);
        }
        public void RemoveDuplicates()
        {
            // Iterate through the list

            while (_head != null)
            {
                // Iterate to the remaining nodes in the list
                IntegerNode current = _head;
                while (current != null && current.Next != null)
                {
                    if (_head.Value == current.Next.Value)
                    {
                        current.Next = current.Next.Next;
                    }

                    current = current.Next;
                }

                _head = _head.Next;
            }
        }
        
        public void Merge(IntegerLinkedList first, IntegerLinkedList second)
        {
            if (first._head == null)
            {
                first._head = second._head;
                return;
            }

            if (second._head == null)
            {
                return;
            }

            while ((first._next != null) && (second != null))
            {
                IntegerNode n = first._next;
                IntegerNode t = second._next;
                first._next = n;
                first = first._next;
                second = t;
            }
        }
        
            


        }



    }

    class IntegerNode
    {
        int _value;
        IntegerNode _next;
        
        public int Value { get { return _value; } }
        public IntegerNode Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public int Count
        {
            get
            {
                if (_next == null)
                    return 1;
                else
                    return 1 +_next.Count;
            }
        }

        public int Sum
        {
            get
            {
                if (_next == null)
                    return _value;
                else
                    return _value + _next.Sum;
            }
        }
        public IntegerNode(int v)
        {
            _value = v;
            _next = null;
        }
        
        public void Append(int v)
        {
            if (_next == null)
                _next = new IntegerNode(v);
            else
            {
                _next.Append(v);
            }
        }

        public override string ToString()
        {
            
            return _value.ToString() + (_next == null ? string.Empty : $", {_next.ToString()}");
            // return the string value and if the _next is empty then stop or if not, print next (recursive) //
        }

        public bool Delete(int doomed)
        {
            if (_next == null)
                return false;
            if (_next.Value == doomed)
            {
                _next = _next.Next;
                return true;
            }
            return _next.Delete(doomed);
        }

        public void RemoveDuplicates()
        {
            if (_next != null)
                _next.RemoveDuplicates();
        }

        

    }

    


    


}