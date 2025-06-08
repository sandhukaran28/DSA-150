/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution
{
    public Node copyRandomList(Node head)
    {
        if (head == null)
        {
            return null;
        }
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();

        Node newHead = new Node(0);

        Node pointer = head, newPointer = newHead;
        while (head != null)
        {
            Node curr = new Node(head.val);
            dic.Add(head, curr);
            newHead.next = curr;
            newHead = newHead.next;
            head = head.next;
        }
        head = pointer;
        newHead = newPointer.next;
        while (head != null)
        {
            Node random = head.random;

            if (random != null && dic.ContainsKey(random))
            {
                newHead.random = dic[random];
            }
            head = head.next;
            newHead = newHead.next;

        }

        return newPointer.next;

    }
}
