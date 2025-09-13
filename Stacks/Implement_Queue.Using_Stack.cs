public class MyQueue
{

    Stack<int> st1 = new Stack<int>();
    Stack<int> st2 = new Stack<int>();

    public MyQueue()
    {

    }

    public void Push(int x)
    {
        st1.Push(x);
    }

    public int Pop()
    {
        if (st2.Count == 0)
        {
            transfer();
        }
        return st2.Pop();
    }

    public int Peek()
    {
        if (st2.Count == 0)
        {
            transfer();
        }
        return st2.Peek();
    }

    private void transfer()
    {
        while (st1.Count > 0)
        {
            st2.Push(st1.Pop());
        }
    }

    public bool Empty()
    {
        return (st1.Count == 0 && st2.Count == 0);
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */