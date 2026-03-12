using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 문자열 → 길이 변환 ===");
string[] words = { "Hello", "World", "C#" };
var converter1 = new Converter<string, int>(a => a.Length);
Console.WriteLine($"Hello → {converter1.Convert(words[0])}");

Console.Write("전체 변환: ");
var wordsLength = converter1.ConvertAll(words);
Console.WriteLine(string.Join(", ", wordsLength));
Console.WriteLine();

Console.WriteLine("=== 정수 → 문자열 변환 ===");
int[] numbers = { 1, 2, 3 };
var converter2 = new Converter<int, string>(a => string.Concat(a.ToString(), "번"));

Console.WriteLine($"1 → {converter2.Convert(numbers[0])}");
Console.Write("전체 변환: ");
var stringNum = converter2.ConvertAll(numbers);
Console.WriteLine(string.Join(", ", stringNum));
Console.WriteLine();

Console.WriteLine("=== 실수 → 정수 변환 ===");
double[] reals = { 3.7, 1.2, 9.9 };
var converter3 = new Converter<double, int>(a => (int)a);

Console.WriteLine($"3.7 → {converter3.Convert(reals[0])}");
Console.Write("전체 변환: ");
var toInt = converter3.ConvertAll(reals);
Console.WriteLine(string.Join(", ", toInt));
Console.WriteLine();