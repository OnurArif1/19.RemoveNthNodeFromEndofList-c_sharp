Node RemoveNthFromEnd(Node head, int n)
{
    Node temp = head;
    Node temp2 = head;
    int check = 0;
    while (temp != null)
    {
        check++;
        temp = temp.next;
    }
    if (check == 1 && n == 1)
    {
        return null;
    }
    else if (check == n)
    {
        head = head.next;
        return head;
    }
    int i = 0;
    while (i < check - n - 1)
    {
        temp2 = temp2.next;
        i++;
    }
    temp2.next = temp2.next.next;
    return head;
}


class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}