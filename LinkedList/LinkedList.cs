using System.Collections;
using System.Collections.Generic;

namespace CSharp.LinkedList
{
    public class LinkedList<T>// : IEnumerable<T>
    {
        public uint Count = 0;
        public ItemList<T>? Head = null;
        public ItemList<T>? Tail = null;
        public bool IsEmpty { get { return Count == 0; } }
        public LinkedList() { }
        public void Add(T data, uint i)
        {
            ItemList<T> item = new ItemList<T>(data);
            if (Head != null)
            {
                uint c = 1;
                ItemList<T> t = Head;
                while (c != i && t.Next != null)
                {
                    t = t.Next;
                    c++;
                }
                t = item;
                Count++;
            }
            else
            {
                Head = item;
                Count++;
            }
        }
        public void AddToStart(T data)
        {
            ItemList<T> item = new ItemList<T>(data);
            if (Head != null)
            {
                item.Next = Head;
                Head = item;
                Count++;
            }
            else
            {
                Head = Tail = item;
                Count++;
            }
            /*
            item.Next = Head;
            Head = item;
            if (count == 0)
            {
                Tail = Head;
            }
            Count++;
            */
        }
        public void AddToEnd(T data)
        {
            ItemList<T> item = new ItemList<T>(data);
            if (Head != null)
            {
                ItemList<T> t = Head;
                while (t.Next != null)
                {
                    t = t.Next;
                }
                t.Next = Tail = item;
                Count++;
            }
            else
            {
                Head = Tail = item;
                Count++;
            }
        }
        public void Remove(T data)
        {
            ItemList<T>? t = Head;
            ItemList<T>? previous = null;
            while (t != null && t.Data != null)
            {
                if (t.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = t.Next;
                        if (t.Next == null)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        Head = Head?.Next;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }
                    Count--;
                }
                previous = t;
                t = t.Next;
            }
        }
        public bool Contains(T data)
        {
            ItemList<T>? t = Head;
            while (t != null && t.Data != null)
            {
                if (t.Data.Equals(data))
                {
                    return true;
                }
                t = t.Next;
            }
            return false;
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void Print()
        {
            string str = "";
            if (Head != null)
            {
                ItemList<T>? t = Head;
                while (t.Next != null)
                {
                    str += t.Data + " ";
                    t = t.Next;
                }
                /*
                for (int i = 0; i < Count; i++)
                {
                    str += t.Data + " ";
                    t = t.Next;
                }
                */
            }
            else
            {
                str = "head is null";
            }
            Console.WriteLine(str);
        }
        /*
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            ItemList<T>? t = Head;
            while (t != null)
            {
                yield return t.Data;
                t = t.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
        */
    }
}