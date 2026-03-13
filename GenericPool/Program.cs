using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

var bullet = new ObjectPool<Bullet>(3);

Console.WriteLine("=== 총알 발사 ===");
bullet.Get();
bullet.Get();
bullet.Get();

