namespace MyList
{
    /// <summary>
    /// Contains all required data for events
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class EventArgs<T>
    {
        public T value;
        public int totalNum;
        public string listName;

        public EventArgs(T value, int totalNum, string listName)
        {
            this.value = value;
            this.totalNum = totalNum;
            this.listName = listName;
        }
    }
}
