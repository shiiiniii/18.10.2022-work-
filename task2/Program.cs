// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Clear();
Console.Write("Введите координату Х: ");
int X = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);
if ( X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}