namespace DataStructuresMadeEasy.Bst
{
    public class Node<T> 
    {
        public T Value { get; private set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T item)
        {
            Value = item;
        }
    }
}
