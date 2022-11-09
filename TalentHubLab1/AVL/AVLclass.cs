using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHubLab1.AVL
{
    public class AVLclass
    {
        public AVLclass()
        {
            Root = null;
            nodeCount = 0;
            NodeList = new List<Applicant>();
            AllApplicantList = new List<Applicant>();
        }

        public Node Root;
        public int nodeCount;
        public List<Applicant> NodeList;
        public List<Applicant> AllApplicantList;

        public Node Insert(Node root, Applicant element)
        {
            
            if (root == null)
            {
                Node node = new Node(element);
                nodeCount++;
                return node;
            }

            if (string.Compare(root.element.DPI, element.DPI) == 1)
                root.left = Insert(root.left, element);
            if (string.Compare(root.element.DPI, element.DPI) == -1)
                root.right = Insert(root.right, element);

            //balance factor 
            int balance = calculateFactor(root);

            if (balance > 1)
            {
                if (string.Compare(root.left.element.DPI, element.DPI) == 1)
                {
                    //single right rotation
                    return RightRotation(root);
                }
                else if (string.Compare(root.left.element.DPI, element.DPI) == -1)
                {
                    //double roght rotation
                    root.left = LeftRotation(root.left);
                    return RightRotation(root);
                }
            }

            if (balance < -1)
            {
                if (string.Compare(root.right.element.DPI, element.DPI) == -1)
                {
                    //single left rotation
                    return LeftRotation(root);
                }
                else if (string.Compare(root.right.element.DPI, element.DPI) == 1)
                {
                    //double left rotation
                    root.right = RightRotation(root.right);
                    return LeftRotation(root);
                }
            }

            return root;
        }


        public int calculateFactor(Node node)
        {
            if (node == null)
                return -1;
            else
                return getHeight(node.left) - getHeight(node.right);
        }

        public int getHeight(Node node)
        {
            if (node == null)
                return -1;
            return maxHeight(getHeight(node.left), getHeight(node.right));
        }

        public int maxHeight(int heightLeft, int HeightRight)
        {
            return (HeightRight > heightLeft) ? HeightRight + 1 : heightLeft + 1;
        }

        public Node RightRotation(Node node)
        {
            Node newRoot = node.left;
            Node rightAux = newRoot.right;
            newRoot.right = node;
            node.left = rightAux;

            return newRoot;
        }

        public Node LeftRotation(Node node)
        {
            Node newRoot = node.right;
            Node leftAux = newRoot.left;
            newRoot.left = node;
            node.right = leftAux;

            return newRoot;
        }


        public void Edit(Node root, Applicant applicant)
        {
            if (root.element.DPI == applicant.DPI)
            {
                //element finded
                root.element.Address = applicant.Address;
                root.element.DateBirth = applicant.DateBirth;

            }
            else if (string.Compare(root.element.DPI, applicant.DPI) == 1 && root.left != null)
            {
                Edit(root.left, applicant);
            }
            else if (string.Compare(root.element.DPI, applicant.DPI) == -1 && root.right != null)
            {
                Edit(root.right, applicant);
            }
        }

        

       

        public Node Delete(Node root, Applicant applicant)
        {
            if (root == null)
                return root;

            if (string.Compare(applicant.DPI, root.element.DPI) == -1)
            {
                root.left = Delete(root.left, applicant);
            }

            else if (string.Compare(applicant.DPI, root.element.DPI) == 1)
            {
                root.right = Delete(root.right, applicant);
            }

            else
            {
                if (root.left == null || root.right == null)
                {
                    Node aux = (root.left != null) ? root.left : root.right;

                    if (aux == null)
                    {
                        aux = root;
                        root = null;
                    }
                    else
                    {
                        root = aux;
                        aux = null;

                    }
                }
                else
                {
                    Node aux = minValueNode(root.right);
                    root.element = aux.element;
                    root.right = Delete(root.right, aux.element);
                }
                

            }

            
            return root;

            int balance = calculateFactor(root);

            if (balance > 1)
            {
                if (string.Compare(root.left.element.DPI, applicant.DPI) == 1)
                {
                    //single right rotation
                    return RightRotation(root);
                }
                else if (string.Compare(root.left.element.DPI, applicant.DPI) == -1)
                {
                    //double roght rotation
                    root.left = LeftRotation(root.left);
                    return RightRotation(root);
                }
            }

            if (balance < -1)
            {
                if (string.Compare(root.right.element.DPI, applicant.DPI) == -1)
                {
                    //single left rotation
                    return LeftRotation(root);
                }
                else if (string.Compare(root.right.element.DPI, applicant.DPI) == 1)
                {
                    //double left rotation
                    root.right = RightRotation(root.right);
                    return LeftRotation(root);
                }
            }

        }
        

        

        public Node minValueNode(Node root)
        {
            Node aux = root;
            while (aux.left != null)
            {
                aux = aux.left;
            }
            return aux;
        }


        public void InorderSearch(Node root, string name)
        {
            if (root == null)
                return;
            InorderSearch(root.left, name);
            if (root.element.Name == name)
            {
                NodeList.Add(root.element);
            }
            InorderSearch(root.right, name);
        }

        public void getAll(Node root)
        {
            if (root == null)
                return;
            if (root.left != null)
                getAll(root.left);
            AllApplicantList.Add(root.element);
            if (root.right != null) 
                getAll(root.right);
        }

        public Applicant SearchByDPI(Node root,  string DPI)
        {
            if (root != null && string.Compare(root.element.DPI, DPI) == 0)
            {
                return root.element;
            }
            else if (root != null)
            {
                if (string.Compare(root.element.DPI, DPI) == 1)
                {
                    return SearchByDPI(root.left, DPI);
                }
                else
                {
                    return SearchByDPI(root.right, DPI);
                }
            }
            return null;
        }
    }
}
