using System;

// README.md를 읽고 아래에 코드를 작성하세요.

GameCharacter warrior = new GameCharacter();
warrior.Name = "홍길동";
warrior.Job = "전사";
warrior.ShowStatus();

warrior.GainExp(50);
warrior.GainExp(30);
warrior.GainExp(40);
warrior.ShowStatus();

Console.WriteLine();

GameCharacter mage = new GameCharacter();
mage.Name = "김철수";
mage.Job = "마법사";
mage.ShowStatus();

mage.GainExp(100);
mage.ShowStatus();

class GameCharacter
{
    public string Name;
    public string Job;
    public int Level = 1;
    public int Exp = 0;

    public void ShowStatus()
    {
        Console.WriteLine($"[{Job}] {Name} - Lv.{Level} (EXP: {Exp}/100)");
    }
    public void GainExp(int amount)
    {
        Exp += amount;
        if (Exp >= 100)
        {
            Exp -= 100;
            Level++;
            Console.WriteLine($"레벨 업! {Name} Lv.{Level} 달성!");
        }
        else
        {
            Console.WriteLine($"경험치 획득! 현재 EXP: {Exp}/100");
        }
    }


}
