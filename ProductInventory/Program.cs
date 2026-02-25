using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 상품 목록 ===");
Product product1 = new Product("노트북", 1500000, 5);
Product product2 = new Product("마우스", 35000, 20);
Product product3 = new Product("키보드", 89000, 15);

Console.WriteLine("\n=== 거래 ===");
product1.Sell(2);
product2.Sell(5);
product3.Sell(20);
product3.AddStock(10);

Console.WriteLine("\n=== 최종 상품 목록 ===");
Console.WriteLine($"{product1.ToString()}");
Console.WriteLine($"{product2.ToString()}");
Console.WriteLine($"{product3.ToString()}");

Console.WriteLine("\n=== 최종 상품 목록 ===");

product1.GetTotalValue();
product2.GetTotalValue();
product3.GetTotalValue();

Console.WriteLine($"---\n전체 재고 총 가치: {(product1.Price * product1.Stock) + (product2.Price * product2.Stock) + (product3.Price * product3.Stock)}원");

class Product
{
    public string Name;
    public int Price;
    public int Stock = 0;

    public Product(string name, int price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
        Console.WriteLine($"[{Name}] {Price}원 (재고: {Stock}개)");
    }

    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"[{Name}] {quantity}개 재고 추가. 현재 재고: {Stock}개");
    }
    public void Sell(int quantity)
    {
        if ((Stock -= quantity) < 0)
        {
            Console.WriteLine($"{Name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {Stock + quantity}개)");
            Stock += quantity; // 판매 실패 시 원래대로 돌려놓기
        }
        else
        {
            Console.WriteLine($"[{Name}] {quantity}개 판매 완료. 남은 재고: {Stock}개");
        }
    }

    public override string ToString()
    {
        return $"[{Name}] {Price}원 (재고: {Stock}개)";
    }

    public void GetTotalValue()
    {
        int totalValue = Price * Stock;
        Console.WriteLine($"[{Name}]: {totalValue}원 (재고: {Stock}개)");
    }
}
