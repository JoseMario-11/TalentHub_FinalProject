using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Structures
{
    public class AVLNode<T>
    {
        public T Key { get; set; }

        public AVLNode<T> Left;

        public AVLNode<T> Right;

        public int Height;

        public AVLNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
            Height = 1;
        }
    }
}
