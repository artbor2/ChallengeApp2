/// Przygotuj program, który policzy ile jakich cyfr
/// występuje w danej liczbie
/// 
/// Przykład:
/// Wyniki dla liczby: 4566
/// 0 => 0
/// 1 => 0
/// 2 => 0
/// 3 => 0
/// 4 => 1
/// 5 => 1
/// 6 => 2
/// 7 => 0
/// 8 => 0
/// 9 => 0

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] digitsStats = new int[10];

foreach (char c in letters)
{
    if (c == '0')
    {
        digitsStats[0]++;
    }
    else if (c == '1')
    {
        digitsStats[1]++;
    }
    else if (c == '2')
    {
        digitsStats[2]++;
    }
    else if (c == '3')
    {
        digitsStats[3]++;
    }
    else if (c == '4')
    {
        digitsStats[4]++;
    }
    else if (c == '5')
    {
        digitsStats[5]++;
    }
    else if (c == '6')
    {
        digitsStats[6]++;
    }
    else if (c == '7')
    {
        digitsStats[7]++;
    }
    else if (c == '8')
    {
        digitsStats[8]++;
    }
    else if (c == '9')
    {
        digitsStats[9]++;
    }
}

Console.WriteLine(numberInString);
Console.WriteLine();
for (int i = 0; i < digitsStats.Length; i++)
{
    Console.WriteLine($"{i} => {digitsStats[i]}");
}


