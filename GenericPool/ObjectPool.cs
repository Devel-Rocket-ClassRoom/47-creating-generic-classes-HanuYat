using System;
using System.Collections.Generic;

class ObjectPool<T> where T : class, IPoolable, new()
{
    private int _maxSize;
    private List<T> _available;
    private List<T> _active;

    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize;
    }
}