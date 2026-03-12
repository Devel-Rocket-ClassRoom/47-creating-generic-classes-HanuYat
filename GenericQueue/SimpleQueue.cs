using System;
using System.Collections.Generic;

class SimpleQueue<T>
{
    private T[] _items;
    private int _count;

    public int Count => _count;
    public bool IsFull => _count == _items.Length;
    public bool IsEmpty => _count == 0;

    public SimpleQueue(int capacity)
    {
        _items = new T[capacity];
        _count = 0;
    }

    public void Enqueue(T item)
    {
        if (IsFull)
        {            
            Console.WriteLine("큐가 가득 찼습니다.");
            return;
        }
        
        _items[_count] = item;
        _count++;
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }

        _count--;
        T item = _items[_count];
        _items[_count] = default(T);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }

        return _items[_count - 1];
    }
}