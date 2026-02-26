using System;
using System.Collections;

// README.md를 읽고 아래에 코드를 작성하세요.

//1
Catalog catalog = new Catalog();
Console.WriteLine(catalog[0]);
Console.WriteLine(catalog[1]);
Console.WriteLine(catalog[2]);

//2
Car cars = new Car(3);

cars[0] = "CLA";
cars[1] = "CLS";
cars[2] = "AMG";

for(int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

//3
Week week = new Week(3);
week[0] = "일요일";
week[1] = "월요일";
week[2] = "화요일";

for(int i = 0; i < week.Length; i++)
{
    Console.WriteLine(week[i]);
}

//4
NickName nickName = new NickName();

nickName["홍길동"] = "RedPlus";
nickName["김철수"] = "BlueStar";

Console.WriteLine($"{nickName["홍길동"]}, {nickName["김철수"]}");

//5
MultiIndexer multi =  new MultiIndexer();
multi[0] = "첫 번째 값";
multi["name"] = "홍길동";
multi["city"] = "서울";

Console.WriteLine($"multi[0] = {multi[0]}");
Console.WriteLine($"multi[\"name\"] = {multi["name"]}");
Console.WriteLine($"multi[\"city\"] = {multi["city"]}");

//6
Example ex =  new Example();
ex.Name = "홍길동";
ex[0] = "첫 번째";
ex[1] = "두 번째";

Console.WriteLine(ex.Name);
Console.WriteLine($"{ex[0]}, {ex[1]}");