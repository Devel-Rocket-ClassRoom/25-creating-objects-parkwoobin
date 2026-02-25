using System;
using System.ComponentModel;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 계좌 개설 ===");
BankAccount account1 = new BankAccount("1001", "홍길동", 100000);
BankAccount account2 = new BankAccount("1002", "이순신", 50000);

BankAccount.ShowTotalAccounts();

Console.WriteLine("=== 거래 ===");
account1.Deposit(50000);
account2.Deposit(30000);
account1.Withdraw(200000);
account1.Withdraw(100000);

Console.WriteLine("\n=== 최종 계좌 정보 ===");
foreach (var account in new[] { account1, account2 })
{
    account.ShowInfo();
}

class BankAccount
{
    private static int TotalAccounts = 0;

    // 인스턴스 멤버
    private string AccountNumber;
    private string _ownerName;
    private int Balance;
    // 생성자
    public BankAccount(string accountNumber, string ownerName, int balance)
    {
        AccountNumber = accountNumber;
        _ownerName = ownerName;
        Balance = balance;
        TotalAccounts++;
        Console.WriteLine($"[{AccountNumber}] {_ownerName} 계좌가 개설되었습니다.");
    }

    public void Deposit(int amount) // 입금
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 입금 완료. 잔액: {Balance}원");
    }
    public void Withdraw(int amount) // 출금
    {
        Balance -= amount;
        if (Balance < 0)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
            Balance += amount; // 출금 실패 시 원래대로 돌려놓기
            return;
        }
        else
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 완료. 잔액: {Balance}원");
        }
    }
    public void ShowInfo()  // 계좌 정보 출력
    {
        Console.WriteLine($"계좌 번호: {AccountNumber}, 예금주: {_ownerName}, 잔액: {Balance}원");
    }
    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}\n");
    }
}
