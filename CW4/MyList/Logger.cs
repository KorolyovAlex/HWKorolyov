using System;

namespace MyList
{
    /// <summary>
    /// Log to console all changes of the list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Logger<T>
    {
        public static void LogNodeAdding(EventArgs<T> args)
        {
            Console.WriteLine($"New node added to {args.listName}: \n Node value is \'{args.value}\'. There is {args.totalNum} elements in {args.listName}");
        }
    }
}
