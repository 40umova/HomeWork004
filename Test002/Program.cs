// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

  Console.Write("Введите число: ");
  int NumA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень: ");
  int NumB = Convert.ToInt32(Console.ReadLine());
  Step(NumA, NumB);

void Step(int NumA, int NumB)
{
    int result = 1;
    for (int i = 1; i <= NumB; i++)
    {
        result = result * NumA;
    }

    Console.WriteLine($"Результат возведения числа {NumA} в степень {NumB} равен {result}");
}
