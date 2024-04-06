﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    [Serializable]
    public class Node
    {
        public Node Next { get; set; }
        public User Data { get; set; }
 
        public Node(User data) 
        {        
            Data = data;
            Next = null;
        }
    }
}
