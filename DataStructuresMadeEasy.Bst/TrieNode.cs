namespace DataStructuresMadeEasy.Bst
{
    //Next property is treated as next level in height
    public class TrieNode
    {
        //Our TrieNode could be made 26 character long a-z 97 to 122
        public string Value { get; set; }
        public TrieNode[] Next { get; set; }

        public TrieNode(short radix)
        {
            Next = new TrieNode[radix];
        }
    }
}
