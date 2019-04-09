namespace MyList
{
    /// <summary>
    /// Class of elements of the list
    /// </summary>
    /// <typeparam name="T"> Type of created list</typeparam>
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
