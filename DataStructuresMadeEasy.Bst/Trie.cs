using System;
using System.Collections.Generic;

namespace DataStructuresMadeEasy.Bst
{
    public class Trie
    {
        private const short Radix = 256;
        private readonly TrieNode root = new TrieNode(Radix);

        public int Count { get; private set; }

        public void Add(string word)
        {
            word = word.ToLower();
            Add(root, word, 0);
        }

        /// <summary>
        /// Recursive method that takes in three parameters
        /// </summary>
        /// <param name="node">the node to begin at for recursion</param>
        /// <param name="word">word to add</param>
        /// <param name="index">the index of word i.e. charAt(index)</param>
        /// <returns></returns>
        private void Add(TrieNode node, string word, int index)
        {
            if (node == null)
            {
                throw new InvalidOperationException("Node cannot be null");
            }

            //check if the index is equal to the length of word 
            //i.e. last character before completing the word
            //no more recursive calls from here on and mark the word sealed
            if (index == word.Length)
            {
                node.Value = word;
                Count++;
                return;
            }

            //Otherwise find the character at a specified postion
            //in the string denoted by index
            var c = word[index];
            //Only create new node only if it is not present in the chain
            //Value of char c will be converted to its ascii value 
            //and will be used in the array (key index)
            if (node.Next[c] == null)
            {
                node.Next[c] = new TrieNode(Radix);
            }
            Add(node.Next[c], word, ++index);
        }


        public bool Delete(string word)
        {
            word = word.ToLower();

            var pathToKey = new Stack<TrieNode>();
            //Find out if key exist
            var result = Remove(root, word, 0, pathToKey);

            //Setting count > 1 because we do not want to remove
            //root node we could also use do while with condition 
            //where node != root
            while (pathToKey.Count > 1 && result != null) 
            {                                               
                var node = pathToKey.Pop();
                for (int i = 0; i < Radix; i++)
                {
                    if (node != null && node.Next[i] == null)
                    {
                        node = null;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return result != null;
        }

        //Path is a stack of all the nodes upto key which can be used to remove if required
        private TrieNode Remove(TrieNode node, string key, int index, Stack<TrieNode> path)
        {
            if (node == null)
            {
                return null;
            }

            path.Push(node);
            if (index == key.Length)
            {
                node.Value = null;
                return node;
            }
            else
            {
                var c = key[index];
                Remove(node.Next[c], key, index + 1, path);
            }
            return null;
        }

        public bool Get(string word)
        {
            word = word.ToLower();

            if (word == null)
            {
                throw new InvalidOperationException("Key cannot be null");
            }

            var node = RetrieveNode(root, word, 0);
            if (node == null)
            {
                return false;
            }

            return node.Value == word;
        }

        private TrieNode RetrieveNode(TrieNode node, string word, int index)
        {
            if (node == null)
            {
                return null;
            }

            if (index == word.Length)
            {
                return node;
            }

            //find the character at a specified postion in the string denoted by index
            char c = word[index];
            return RetrieveNode(node.Next[c], word, ++index);
        }
    }
}