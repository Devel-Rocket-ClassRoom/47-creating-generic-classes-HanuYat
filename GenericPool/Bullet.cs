using System;

class Bullet : IPoolable
{
    public bool IsActive { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public void Fire(int x, int y)
    {
        IsActive = true;
        Console.WriteLine($"총알 발사! 위치: ({x}, {y})");
    }

    public void Reset()
    {
        IsActive = false;
        X = 0;
        Y = 0;
    }
}