using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
