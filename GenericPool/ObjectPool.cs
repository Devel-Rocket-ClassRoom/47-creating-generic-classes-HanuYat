using System;
using System.Collections.Generic;

class ObjectPool<T> where T : class, IPoolable, new()
{
    private int _maxSize;
    private List<T> _available;
    private List<T> _active;

    public int AcitveCount => _active.Count;
    public int AvailableCount => _available.Count;

    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize;
    }

    public void Get()
    {
        if (_available == null && _available.Count + _active.Count < _maxSize)
        {
            _available = new List<T>();
        }

        _active[_active.Count - 1] = _available[_available.Count - 1];
        _available.RemoveAt(_available.Count - 1);

        if (_available.Count + _active.Count >= _maxSize)
        {
            Console.WriteLine("풀이 가득 찼습니다!");

            return;
        }
    }

    public void Return(T item)
    {
        item.Reset();
        _active.Remove(item);
        _available.Add(item); 
    }
}