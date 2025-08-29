using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueuingCashier
{
    internal class QueueingSystem
    {
    }
    public static class QueueManager
    {
        public static Queue<int> studentQueue = new Queue<int>();
        private static int counter = 0;

        public static int EnqueueStudent()
        {
            counter++;
            studentQueue.Enqueue(counter);
            return counter;
        }

        public static int? DequeueStudent()
        {
            if (studentQueue.Count > 0)
                return studentQueue.Dequeue();
            return null;
        }

        public static int? PeekNext()
        {
            if (studentQueue.Count > 0)
                return studentQueue.Peek();
            return null;
        }

        public static int QueueCount()
        {
            return studentQueue.Count;
        }
    }
}
