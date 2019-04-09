using System;

namespace MyList
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            LinkedList<int> calories1 = new LinkedList<int>(nameof(calories1));
            LinkedList<int> calories2 = new LinkedList<int>(nameof(calories2));
            calories1.NodeAdded += Logger<int>.LogNodeAdding;
            calories1.NodeAdded += calories2.DoesAnotherContains;
            calories2.NodeAdded += Logger<int>.LogNodeAdding;
            calories2.NodeAdded += calories1.DoesAnotherContains;
            calories1.Add(1000);
            calories1.Add(1739);
            calories2.Add(994);
            calories1.Add(994);
            calories2.Add(1000);
            calories2.Add(1739);
        }
    }
}
