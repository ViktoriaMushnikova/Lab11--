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


Console.WriteLine("Шаг 4. Дубликаты в массиве");
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


Console.WriteLine("Шаг 5. Выход сразу из двух циклов");
int days = 5;
int lessonsPerDay = 6;
bool founds = false;
for (int day = 1; day <= days && !founds; day++)
{
    for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
    {
        bool isFree = (day == 3 && lesson == 4);
        if (isFree)
        {
            Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
            founds = true;
            break;
        }
    }
}
if (!founds)
{
    Console.WriteLine("Свободных слотов нет");
}


Console.WriteLine("Задача А");
int[] numbers = { 9, 10, 7, 5 };
int numberIs = 9;
bool flag = false;
for (int k = 0; k < numbers.Length; k++)
{
    if (numbers[k] == numberIs)
    {
        Console.WriteLine($"Индекс искомого числа: {numbers[k]}");
        flag = true;
        break;
    }
}
if (!flag)
{
    Console.WriteLine("Искомого числа нет");
}


Console.WriteLine("Задача В");
int[] num = { 10, 9, 4, 6, 7 };
int summa = 0;
foreach (int r in num)
{
    if (r % 2 != 0)
    {
        continue;
    }
    summa += r;
}
Console.WriteLine($"Сумма чётных чисел: {summa}");


Console.WriteLine("Вариант 8");
int[] number1 = { 9, 8, 4, 3, 5 };
int[] number2 = { 1, 2, 10, 12, 9 };
bool flagNum = false;
for (int a = 0; a < number1.Length && !flagNum; a++)
{
    for (int o = 0; o < number2.Length; o++)
    {
        if (number1[a] == number2[o])
        {
            Console.WriteLine($"Найдено общее число {number1[a]}");
            flagNum = true;
            break;
        }
    }
}
if (!flagNum)
{
    Console.WriteLine("Общее число не найдено");
}


Console.WriteLine("Вариант 9");
string word = "шалаш";
bool flagWord = true;
for (int l = 0; l < word.Length / 2; l++)
{
    if (word[l] != word[word.Length - 1 - l])
    {
        flagWord = false;
        break;
    }
}
Console.WriteLine(flagWord ? $"Слово {word} - палиндром" : $"Слово {word} не палиндром");