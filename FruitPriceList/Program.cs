using System;

// README.md를 읽고 코드를 작성하세요.

FruitPriceList list = new FruitPriceList(5);

list.Add("사과", 1500);
list.Add("바나나", 3000);
list.Add("딸기", 8000);

Console.WriteLine($"등록된 과일 수: {list.Count}\n");
Console.WriteLine($"사과 가격: {list["사과"]}원");
Console.WriteLine($"바나나 가격: {list["바나나"]}원");
Console.WriteLine($"포도 가격: {list["포도"]}원");
Console.WriteLine();
Console.WriteLine($"0번: {list[0]}");
Console.WriteLine($"1번: {list[1]}");
Console.WriteLine($"2번: {list[2]}");