using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Structures
{
    public class AVL <T, K>
    {
        AVLNode<T> Root;

        public int Count { get; set; }

        public delegate int Delegate(T k1, T k2);
        public Delegate Comparator;

        public delegate int Delegate2(K k1, T k2);
        public Delegate2 Comparator2;

        public delegate int Delegate3(K k1, T k2);
        public Delegate3 Comparator3;

        public AVL(Delegate comparator, Delegate2 comparator2, Delegate3 comparator3)
        {
            Root = null;
            Comparator = comparator;
            Comparator2 = comparator2;
            Comparator3 = comparator3;
        }

        public bool Insert(T key)
        {
            bool verification = false;
            Insert(ref Root, key, ref verification);
            return verification;
        }

        void Insert(ref AVLNode<T> root, T key, ref bool verification)
        {
            if (root == null)
            {
                root = new AVLNode<T>(key);
                verification = true;
                Count++;
            }
            else if (Comparator(key, root.Key) == 0)
            {
                verification = false;
            }
            else if (Comparator(key, root.Key) > 0)
            {
                Insert(ref root.Right, key, ref verification);
            }
            else if (Comparator(key, root.Key) < 0)
            {
                Insert(ref root.Left, key, ref verification);
            }
            if (Comparator(key, root.Key) != 0)
            {
                if (root.Left == null)
                {
                    root.Height = 1 + root.Right.Height;
                }
                else if (root.Right == null)
                {
                    root.Height = 1 + root.Left.Height;
                }
                else
                {
                    root.Height = 1 + Math.Max(root.Left.Height, root.Right.Height);
                }

                int BF = GetBalanceFactor(root);

                if (BF > 1)
                {
                    if (GetBalanceFactor(root.Left) < 0)
                    {
                        root.Left = SimpleRotationLeft(root.Left);
                        root = SimpleRotationRight(root);
                    }
                    else
                    {
                        root = SimpleRotationRight(root);
                    }
                }
                if (BF < -1)
                {
                    if (GetBalanceFactor(root.Right) > 0)
                    {
                        root.Right = SimpleRotationRight(root.Right);
                        root = SimpleRotationLeft(root);
                    }
                    else
                    {
                        root = SimpleRotationLeft(root);
                    }
                }
            }
        }

        int GetBalanceFactor(AVLNode<T> root)
        {
            if (root.Left == null && root.Right == null)
            {
                return 0;
            }
            else if (root.Left == null)
            {
                return -root.Right.Height;
            }
            else if (root.Right == null)
            {
                return root.Left.Height;
            }
            return root.Left.Height - root.Right.Height;
        }

        AVLNode<T> SimpleRotationLeft(AVLNode<T> root)
        {
            AVLNode<T> x = root;
            AVLNode<T> y = root.Right;
            AVLNode<T> z = root.Right.Left;

            y.Left = x;
            x.Right = z;

            if (x.Right == null && x.Left == null)
            {
                x.Height = 1;
            }
            else if (x.Right == null)
            {
                x.Height = 1 + x.Left.Height;
            }
            else if (x.Left == null)
            {
                x.Height = 1 + x.Right.Height;
            }
            else
            {
                x.Height = 1 + Math.Max(x.Left.Height, x.Right.Height);
            }

            if (y.Right == null)
            {
                y.Height = 1 + y.Left.Height;
            }
            else
            {
                y.Height = 1 + Math.Max(y.Left.Height, y.Right.Height);
            }
            return y;
        }

        AVLNode<T> SimpleRotationRight(AVLNode<T> root)
        {
            AVLNode<T> x = root;
            AVLNode<T> y = root.Left;
            AVLNode<T> z = root.Left.Right;

            y.Right = x;
            x.Left = z;

            if (x.Right == null && x.Left == null)
            {
                x.Height = 1;
            }
            else if (x.Left == null)
            {
                x.Height = 1 + x.Right.Height;
            }
            else if (x.Right == null)
            {
                x.Height = 1 + x.Left.Height;
            }
            else
            {
                x.Height = 1 + Math.Max(x.Left.Height, x.Right.Height);
            }

            if (y.Left == null)
            {
                y.Height = 1 + y.Right.Height;
            }
            else
            {
                y.Height = 1 + Math.Max(y.Left.Height, y.Right.Height);
            }
            return y;
        }

        /// <summary>
        /// Change the value of an object
        /// </summary>
        /// <param name="key">Value to be change</param>
        /// <param name="newKey">New value to replace</param>
        /// <returns>bool value</returns>
        public bool Update(K key, T newKey)
        {
            var verification = false;
            AVLNode<T> aux = Find(ref Root, key, ref verification);
            if (aux != null)
            {
                aux.Key = newKey;
            }
            return verification;
        }

        public T Find(K key)
        {
            bool verification = false;
            var value = Find(ref Root, key, ref verification);
            if (value != null)
            {
                return value.Key;
            }
            return default(T);
        }

        AVLNode<T> Find(ref AVLNode<T> root, K key, ref bool verification)
        {
            if (root == null)
            {
                verification = false;
                return null;
            }
            else if (Comparator2(key, root.Key) == 0)
            {
                verification = true;
                return root;
            }
            else if (Comparator2(key, root.Key) > 0)
            {
                return Find(ref root.Right, key, ref verification);
            }
            else
            {
                return Find(ref root.Left, key, ref verification);
            }
        }

        public Queue<T> FindAll(K key)
        {
            Queue<T> objects = new Queue<T>();
            FindAll(Root, key, ref objects);
            return objects;
        }

        void FindAll(AVLNode<T> root, K key, ref Queue<T> queue)
        {
            if (root != null)
            {
                bool verification = false;
                while (!verification && root != null)
                {
                    if (Comparator3(key, root.Key) == 0)
                    {
                        verification = true;
                        FindAllObjects(root, key, ref queue);
                    }
                    else if (Comparator3(key, root.Key) > 0)
                    {
                        root = root.Right;
                    }
                    else
                    {
                        root = root.Left;
                    }
                }
            }
        }

        void FindAllObjects(AVLNode<T> root, K key, ref Queue<T> queue)
        {
            if (root.Left == null && root.Right == null)
            {
                if (Comparator3(key, root.Key) == 0)
                {
                    queue.Enqueue(root.Key);
                }
            }
            else if (root.Left == null)
            {
                if (Comparator3(key, root.Key) == 0)
                {
                    queue.Enqueue(root.Key);
                }
                FindAllObjects(root.Right, key, ref queue);
            }
            else if (root.Right == null)
            {
                FindAllObjects(root.Left, key, ref queue);
                if (Comparator3(key, root.Key) == 0)
                {
                    queue.Enqueue(root.Key);
                }
            }
            else
            {
                FindAllObjects(root.Left, key, ref queue);
                if (Comparator3(key, root.Key) == 0)
                {
                    queue.Enqueue(root.Key);
                }
                FindAllObjects(root.Right, key, ref queue);
            }
        }

        public bool Remove(T key)
        {
            bool verification = false;
            Remove(ref Root, key, ref verification);
            return verification;
        }

        void Remove(ref AVLNode<T> root, T key, ref bool verification)
        {
            if (root != null)
            {
                if (Comparator(key, root.Key) == 0)
                {
                    if (root.Left == null && root.Right == null)
                    {
                        root = null;
                        Count--;
                    }
                    else if (root.Left != null && root.Right != null)
                    {
                        var aux = LeftGreater(root);
                        aux.Right = root.Right;
                        aux.Left = root.Left;
                        root = aux;
                        Count--;
                    }
                    else
                    {
                        if (root.Right != null)
                        {
                            root = root.Right;
                            Count--;
                        }
                        else
                        {
                            root = root.Left;
                            Count--;
                        }
                    }
                    verification = true;
                }
                else if (Comparator(key, root.Key) > 0)
                {
                    Remove(ref root.Right, key, ref verification);
                }
                else
                {
                    Remove(ref root.Left, key, ref verification);
                }

                if (root != null)
                {
                    if (root.Left != null || root.Right != null)
                    {
                        if (root.Left == null)
                        {
                            root.Height = 1 + root.Right.Height;
                        }
                        else if (root.Right == null)
                        {
                            root.Height = 1 + root.Left.Height;
                        }
                        else
                        {
                            root.Height = 1 + Math.Max(root.Left.Height, root.Right.Height);
                        }

                        int BF = GetBalanceFactor(root);

                        if (BF > 1)
                        {
                            if (GetBalanceFactor(root.Left) < 0)
                            {
                                root.Left = SimpleRotationLeft(root.Left);
                                root = SimpleRotationRight(root);
                            }
                            else
                            {
                                root = SimpleRotationRight(root);
                            }
                        }
                        if (BF < -1)
                        {
                            if (GetBalanceFactor(root.Right) > 0)
                            {
                                root.Right = SimpleRotationRight(root.Right);
                                root = SimpleRotationLeft(root);
                            }
                            else
                            {
                                root = SimpleRotationLeft(root);
                            }
                        }
                    }
                    else
                    {
                        root.Height = 1;
                    }
                }
            }
        }

        AVLNode<T> LeftGreater(AVLNode<T> root)
        {
            AVLNode<T> greater = null;
            AVLNode<T> aux = root;
            if (aux.Left.Right == null)
            {
                if (aux.Left != null)
                {
                    greater = aux.Left;
                    aux.Left = aux.Left.Left;
                }
                else
                {
                    greater = aux.Left;
                    aux.Left = null;
                }
            }
            else
            {
                aux = root.Left;
                var verification = true;
                while (aux != null && verification)
                {
                    if (aux.Right.Right == null)
                    {
                        if (aux.Right.Left != null)
                        {
                            greater = aux.Right;
                            aux.Right = aux.Right.Left;
                            verification = false;
                        }
                        else
                        {
                            greater = aux.Right;
                            aux.Right = null;
                            verification = false;
                        }
                    }
                    else
                    {
                        aux = aux.Right;
                    }
                }
            }
            return greater;
        }
    }
}
