using System;
using System.Collections.Generic;

class ObjectPool<T> where T : class, IPoolable, new()
{
    private int _maxSize;
    private List<T> _available;
    private List<T> _active;

    // ActiveCount 속성 (읽기 전용)
    public int ActiveCount => _active.Count;
    // AvailableCount 속성 (읽기 전용)
    public int AvailableCount => _available.Count;

    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize;
        _available = new List<T>(maxSize);
        _active = new List<T>(maxSize);
    }

    public T Get()
    {
        T item = null;

        // 1. 비활성 목록에 있으면 꺼냄
        if (_available.Count > 0)
        {
            item = _available[_available.Count - 1];
            _available.RemoveAt(_available.Count - 1);
        }
        // 2. 없는데 아직 더 만들 수 있으면 생성
        else if (ActiveCount + AvailableCount < _maxSize)
        {
            item = new T();
        }
        // 3. 풀이 가득 차면 null 반환
        else
        {
            Console.WriteLine("풀이 가득 찼습니다!");
            return null;
        }

        _active.Add(item);
        return item;
    }

    public void Return(T item)
    {
        if (item == null || !_active.Contains(item)) return;

        item.Reset(); // 오브젝트 초기화
        _active.Remove(item); // 활성에서 제거
        _available.Add(item); // 비활성에 추가
    }
}