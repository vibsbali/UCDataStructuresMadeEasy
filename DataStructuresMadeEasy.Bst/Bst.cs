using System;
using System.Collections.Generic;

namespace DataStructuresMadeEasy.Bst
{
    public class Bst<T> where T : IComparable<T>
    {
        private Node<T> head;
        public int Count { get; private set; } 

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                Count++;
                return;
            }

            var node = head;
            while (node != null)
            {
                if (node.Value.CompareTo(item) < 0)
                {
                    if (node.Right == null)
                    {
                        node.Right = new Node<T>(item);
                        break;
                    }

                    node = node.Right;
                }
                else if(node.Value.CompareTo(item) > 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node<T>(item);
                        break;
                    }
                    node = node.Left;
                }
                else
                {
                    throw new InvalidOperationException("Cannot add duplicate item");
                }
            }

            Count++;
        }

        public void Remove(T item)
        {
            Node<T> parent;
            Node<T> nodeToRemove;
            bool isLeftOfParent = false;

            if (Find(item, out parent, out nodeToRemove, ref isLeftOfParent))
            {
                if (nodeToRemove.Right == null)
                {
                    //if tail remove tail and update pointer
                    if (nodeToRemove.Left == null)
                    {
                        //If it is left child
                        if (isLeftOfParent)
                        {
                            parent.Left = null;
                        }
                        else
                        {
                            parent.Right = null;
                        }
                    }
                    //otherwise left is not null but right is null i.e. left child is present
                    if (isLeftOfParent)
                    {
                        parent.Left = nodeToRemove.Left;
                    }
                    else
                    {
                        parent.Right = nodeToRemove.Left;
                    }
                    Count--;
                    return;
                }
                //i.e. node has a right child 
                var existingLeft = nodeToRemove.Left;
                var existingRight = nodeToRemove.Right;
                //check if right has a left child
                if (nodeToRemove.Right.Left == null)
                {
                    //if is left child
                    if (isLeftOfParent)
                    {
                        parent.Left = parent.Left.Right;
                        parent.Left.Left = existingLeft;
                    }
                    else
                    {
                        parent.Right = parent.Right.Right;
                        parent.Right.Left = existingLeft;
                    }
                    Count--;
                    return;
                }
                //otherwise node to remove has a right child which in turn has a left child, so find the left most child and move into the position
                var leftMostChild = nodeToRemove.Right.Left;
                Node<T> tempParent = nodeToRemove.Right;
                while (leftMostChild.Left != null)
                {
                    tempParent = leftMostChild;
                    leftMostChild = tempParent.Left;
                }

                if (isLeftOfParent)
                {
                    parent.Left = leftMostChild;
                    parent.Left.Left = existingLeft;
                    parent.Left.Right = existingRight;
                }
                else
                {
                    parent.Right = leftMostChild;
                    parent.Right.Left = existingLeft;
                    parent.Right.Right = existingRight;
                }
                tempParent.Left = null;
                Count--;
                return;
            }
            throw new InvalidOperationException("No item found");
        }

        //returns parent, node and if it is left or right of parentNode
        private bool Find(T item, out Node<T> parent, out Node<T> node, ref bool isLeft)
        {
            //set node to head ie. start from head
            node = head;
            parent = null;

            while (node != null)
            {
                //if node's value is same as item it means we have found the node
                if (node.Value.CompareTo(item) == 0)
                {
                    return true;
                }
                if (node.Value.CompareTo(item) < 0)
                {
                    parent = node;
                    isLeft = false;
                    node = node.Right;
                }
                else
                {
                    parent = node;
                    isLeft = true;
                    node = node.Left;
                }
            }

            //if we can't find anything
            return false;
        }

        public void PrintInOrderTraversal()
        {
            var node = head;

            InOrderTraversal(node);
        }

        private void InOrderTraversal(Node<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Value);
                InOrderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal()
        {
            var node = head;

            PreOrderTraversal(node);
        }

        private void PreOrderTraversal(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal()
        {
            var node = head;

            PostOrderTraversal(node);
        }

        private void PostOrderTraversal(Node<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.WriteLine(node.Value);
            }
        }

        public IEnumerable<T> BreadthFirstSearch()
        {
            throw new NotImplementedException();
        } 
    }
}