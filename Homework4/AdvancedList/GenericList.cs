using System;

namespace AdvancedList
{
    public class GenericList<T>
    {
        private Node<T> tail;

        public GenericList()
        {
            tail = Head = null;
        }

        public Node<T> Head { get; private set; }

        public void Add(T t)
        {
            var n = new Node<T>(t);
            if (tail == null)
            {
                Head = tail = n;
            }

            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void Foreach(Action<T> action)
        {
            var n = Head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }
}