// Linked Lists  Push amp BuildOneTwoThree
// https://www.codewars.com/kata/55be95786abade3c71000079

namespace codewars.com.Kata._7_kyu.Linked_Lists__Push_amp_BuildOneTwoThree
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static Node Push(Node head, int data)
        {
            Node t = new Node(data);
            t.Next = head;
            return t;
        }

        public static Node BuildOneTwoThree()
        {
            Node chained = null;
            chained = Node.Push(chained, 3);
            chained = Node.Push(chained, 2);
            chained = Node.Push(chained, 1);
            return chained;
        }
    }
}