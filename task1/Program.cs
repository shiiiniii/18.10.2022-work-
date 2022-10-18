// Дано число. Проверить кратно ли оно 7 и 23 - 
//делится и на 7 и на 23 без остатка

Console.Clear();
Console.Write("Введите число, которое хотите проверить: ");
int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно и 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} не кратно и 7 и 23");
}