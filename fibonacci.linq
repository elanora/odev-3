<Query Kind="Program" />

void Main()
{
	int i, fibo = 0, fibo1 = 1, fibo2 = 0, sayi;
    Console.Write("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= sayi; i++)
{
fibo = fibo1 + fibo2;
fibo2 = fibo1;
fibo1 = fibo;
}
Console.Write("Fibonacci Dizisindeki Karşılığı = " + fibo);


}

// Define other methods and classes here
