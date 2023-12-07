using System.Collections;
using System.Numerics;

namespace SkipList;

class SkipList : IEnumerable
{
    private class Node
    {
        public Node[] Next { get; private set; }
        public int Value { get; private set; }

        public Node(int value, int level)
        {
            Value = value;
            Next = new Node[level];
        }
    }

    private Node _head = new Node(0, 33); // The max. number of levels is 33
    private Random _rand = new Random();
    private int _levels = 1;

    /// <summary>
    /// Inserts a value To the skip list.
    /// </summary>
    public void Insert(int value)
    {
        // Determine the level of the new node. Generate a random number R. The number of
        // 1-bits before we encounter the first 0-bit is the level of the node. Since R is
        // 32-bit, the level can be at most 32.
        var level = 0;
        for (var R = _rand.Next(); (R & 1) == 1; R >>= 1)
        {
            level++;
            if (level == _levels)
            {
                _levels++;
                break;
            }
        }

        // Insert this node To the skip list
        Node newNode = new Node(value, level + 1);
        Node cur = _head;
        for (var i = _levels - 1; i >= 0; i--)
        {
            for (; cur.Next[i] != null; cur = cur.Next[i])
            {
                if (cur.Next[i].Value > value) break;
            }

            if (i <= level)
            {
                newNode.Next[i] = cur.Next[i];
                cur.Next[i] = newNode;
            }
        }
    }

    /// <summary>
    /// Returns whether a particular value already exists in the skip list
    /// </summary>
    public bool Contains(int value)
    {
        Node cur = _head;
        for (int i = _levels - 1; i >= 0; i--)
        {
            for (; cur.Next[i] != null; cur = cur.Next[i])
            {
                if (cur.Next[i].Value > value) break;
                if (cur.Next[i].Value == value) return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Attempts to remove one occurence of a particular value from the skip list. Returns
    /// whether the value was found in the skip list.
    /// </summary>
    public bool Remove(int value)
    {
        Node cur = _head;

        bool found = false;
        for (int i = _levels - 1; i >= 0; i--)
        {
            for (; cur.Next[i] != null; cur = cur.Next[i])
            {
                if (cur.Next[i].Value == value)
                {
                    found = true;
                    cur.Next[i] = cur.Next[i].Next[i];
                    break;
                }

                if (cur.Next[i].Value > value) break;
            }
        }

        return found;
    }

    public IEnumerator<int> GetEnumerator()
    {
        Node cur = _head.Next[0];
        while (cur != null)
        {
            yield return cur.Value;
            cur = cur.Next[0];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public static class TestSkipList
{
    public static void Main()
    {
        SkipList list = new SkipList();

        list.Insert(9);
        list.Insert(1);
        list.Insert(2);
        list.Insert(15);
        list.Insert(0);

        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }
}