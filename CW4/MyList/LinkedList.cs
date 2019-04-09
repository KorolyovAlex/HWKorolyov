using System;

namespace MyList
{
    /// <summary>
    /// Linked list of T-type elements
    /// </summary>
    /// <typeparam name="T"> Type of created list</typeparam>
    class LinkedList<T>
    {///
        public string listName;
        public Node<T> head;
        public Node<T> tail;
        public int count = 0;

        public delegate void ListChanged(EventArgs<T> args);
        public event ListChanged NodeAdded;

        /// <summary>
        /// Constructor for LinkedList
        /// </summary>
        /// <param name="listName">Name of created list</param>
        public LinkedList(string listName)
        {
            this.listName = listName;
        }

        /// <summary>
        /// Add new node to list
        /// </summary>
        /// <param name="value">Value of new node</param>
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            count++;
            NodeAdded(new EventArgs<T>(node.Value, count, listName));
        }

        /// <summary>
        /// Searchs node in the list
        /// </summary>
        /// <param name="node">Node to search</param>
        /// <returns>Does list contains argument node</returns>
        public bool Search(Node<T> node)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(node.Value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Checking does list contains new element of another list
        /// </summary>
        /// <param name="args">Event arguments</param>
        public void DoesAnotherContains(EventArgs<T> args)
        {
            if (Search(new Node<T>(args.value)))
            {
                Console.WriteLine($"{args.listName} also contains similar element\n");
            }
        }
    }
}
