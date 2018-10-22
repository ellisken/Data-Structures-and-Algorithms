using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        //Constructor requires value for a node
        public Node(object value)
        {
            Value = value;
        }
    }
}
