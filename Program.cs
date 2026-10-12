Console.WriteLine("Шаг 1. Линейный поиск с флагом");
int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 2005;
bool found = false;

foreach (int number in recordBooks)
{
    if (number == target)
    {
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Студент найден" : "Студент не найден");


Console.WriteLine("Шаг 2. Проверка числа на простоту");
int variant = 1;
bool isPrime = true;
if (variant == 1)
{
    Console.WriteLine("1 не считается ни простым ни составным числом");

}
else
{
    for (int divisor = 2; divisor < variant; divisor++)
    {
        if (variant % divisor == 0)
        {
            isPrime = false;
            break;
        }

    }
    Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}


Console.WriteLine("Шаг 3. continue для пропуска элементов");
int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
int count = 0;
foreach (int points in pointsPerLab)
{
    if (points < 0)
    {
        continue;
    }
    sum += points;
    count++;
}
Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
Console.WriteLine($"Работ было сдано: {count}");


Console.WriteLine("Дубликаты в массиве");
int[] groupIds = { 101, 104, 107, 104, 110, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length && !hasDuplicates; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            Console.WriteLine($"Совпавшие номера зачётки: {groupIds[i]} и {groupIds[j]}");
            hasDuplicates = true;
            break;
        }
    }
}
Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");
