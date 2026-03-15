using System;

var pool = new ObjectPool<Bullet>(3);

Console.WriteLine("=== 총알 발사 ===");
var b1 = pool.Get(); b1?.Fire(10, 20);
var b2 = pool.Get(); b2?.Fire(30, 40);
var b3 = pool.Get(); b3?.Fire(50, 60);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");

Console.WriteLine("\n=== 풀 초과 시도 ===");
var b4 = pool.Get(); // null 반환 및 메시지 출력

Console.WriteLine("\n=== 반납 후 재사용 ===");
pool.Return(b1); // b1 반납
Console.WriteLine("총알 반납됨");
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");

var b5 = pool.Get(); // 재사용
b5?.Fire(100, 200);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");