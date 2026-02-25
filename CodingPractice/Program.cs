using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Dog myDog = new Dog();  // 1. 간단한 클래스와 개체
myDog.Name = "초코";
myDog.Age = 3;
myDog.Bark();

Monster monster1 = new Monster();  // 2. var 키워드로 개체 생성
Console.WriteLine(monster1);
Monster monster2 = new Monster();
Console.WriteLine(monster2);

Calculator calc = new Calculator();  // 3. 인스턴스 메서드
calc.Add(5, 3);
calc.Multiply(4, 6);

Counter counter = new Counter();  // 4. 인스턴스 메서드와 필드
counter.Increment();
counter.Increment();
counter.Increment();
counter.Reset();

GameManager.TotalPlayers = 10;  // 5. 정적 멤버와 인스턴스 멤버
GameManager.ShowStatus();
GameManager player1 = new GameManager();
player1.PlayerName = "홍길동";
player1.Greet();

Greeting.SayHello();  // 6. 여러 클래스 함께 사용
Farewell.Wave();
Greeting greeter = new Greeting();
greeter.SayGoodbye();
Farewell fareweller = new Farewell();
fareweller.Bow();

Item item = new Item();  // 7. ToString() 기본 동작
item.Name = "포션";
item.Price = 100;
Console.WriteLine(item);

Item2 item2 = new Item2();  // 8. ToString() 오버라이드
item2.Name = "포션";
item2.Price = 100;
Console.WriteLine(item2.ToString());

Player player_1 = new Player();  // 9. ToString() 활용
player_1.Name = "전사";
player_1.Level = 10;
player_1.Health = 200;


Player player_2 = new Player();
player_2.Name = "마법사";
player_2.Level = 5;
player_2.Health = 150;

Console.WriteLine(player_1);
Console.WriteLine(player_2);

Enemy[] enemies = new Enemy[3];  // 10. 클래스 배열
enemies[0] = new Enemy("고블린", 50);
enemies[1] = new Enemy("오크", 100);
enemies[2] = new Enemy("드래곤", 500);

for (int i = 0; i < enemies.Length; i++)
{
    enemies[i].ShowInfo();
}



Item1[] items = new Item1[3];   // 11. foreach로 클래스 배열 순회
Console.WriteLine("\n=== 인벤토리 ===");
items[0] = new Item1() { Name = "검", Price = 500 };
items[1] = new Item1() { Name = "방패", Price = 300 };
items[2] = new Item1() { Name = "포션", Price = 50 };

foreach (var item1 in items)
{
    Console.WriteLine(item1);
}

Character char1 = new Character     // 12. 개체 이니셜라이저
{
    Name = "홍길동",
    Level = 1,
    Job = "전사"
};

Character char2 = new Character
{
    Name = "이순신",
    Level = 5,
    Job = "궁수"
};

Student[] student1 = new Student[3]       // 13. ToString()과 개체 이니셜라이저
{
    new Student { Name = "김철수", Score = 85 },
    new Student { Name = "이영희", Score = 92 },
    new Student { Name = "박민수", Score = 78 }
};

foreach (var student in student1)
{
    Console.WriteLine(student);
}






class Dog   // 1. 간단한 클래스와 개체
{
    public string Name;
    public int Age;
    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
        Console.WriteLine($"이름: {Name} 나이: {Age}");
    }
}

class Monster   // 2. var 키워드로 개체 생성
{
    public string Name;
}

class Calculator    // 3. 인스턴스 메서드
{
    public void Add(int x, int y)
    {
        Console.WriteLine($"합계: {x + y}");
    }
    public void Multiply(int x, int y)
    {
        Console.WriteLine($"곱: {x * y}");
    }
}

class Counter   // 4. 인스턴스 메서드와 필드
{
    public int Count = 0;
    public void Increment()
    {
        Count++;
        Console.WriteLine($"현재 카운트: {Count}");
    }
    public void Reset()
    {
        Count = 0;
        Console.WriteLine("카운트가 초기화되었습니다.");
    }
}

class GameManager   // 5. 정적 멤버와 인스턴스 멤버
{
    public static int TotalPlayers;  // 정적 필드
    public string PlayerName;   // 인스턴스 필드

    public static void ShowStatus() // 정적 메서드
    {
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }
    public void Greet() // 인스턴스 메서드
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }
}

class Greeting  // 6. 여러 클래스 함께 사용
{
    public static void SayHello()
    {
        Console.WriteLine("안녕하세요!");
    }
    public void SayGoodbye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

class Farewell  // 6. 여러 클래스 함께 사용
{
    public static void Wave()
    {
        Console.WriteLine("(손을 흔든다)");
    }
    public void Bow()
    {
        Console.WriteLine("(인사한다)");
    }
}

class Item      // 7. ToString() 기본 동작
{
    public string Name;
    public int Price;
}

class Item2     // 8. ToString() 오버라이드
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[아이템] {Name} - {Price}골드";
    }
}

class Player    // 9. ToString() 활용
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"[{Level}레벨] {Name} (HP: {Health})";
    }
}



class Enemy     // 10. 클래스 배열
{
    public string Name;
    public int Health;


    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP {Health}");
    }
}

class Item1
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"{Name}: {Price}골드";
    }
}

class Character
{
    public string Name;
    public int Level;
    public string Job;
}

class Student
{
    public string Name;
    public int Score;

    public override string ToString()
    {
        return $"{Name}: {Score}점";
    }
}