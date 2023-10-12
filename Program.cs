//("1. Imprimir 1-255​");
Console.WriteLine("1. Imprimir 1-255​");


static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}

// 2 Imprimir números impares entre 1-255​
PrintNumbers();
Console.WriteLine("************************");

static void PrintOddNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
// 3Imprimir sumas
PrintOddNumbers();
Console.WriteLine("************************");
static void PrintNumbersWithSum()
{
    int sum = 0;

    for (int i = 0; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine($"Numero: {i} Suma: {sum}");
        Console.WriteLine("************************");
    }
}
PrintNumbersWithSum();



//4 Iterar a través de una matriz​ 
static void LoopArray(int[] numbers)
{
    foreach (int item in numbers)
    {
        Console.WriteLine(item);
    }
}

int[] myArray = { 1, 2, 3, 4, 5 };
LoopArray(myArray);


Console.WriteLine("****************************");


// 5 Encuentra el valor máximo

static int FindMax(int[] numbers)
{
    return numbers.Max();
}

int[] sampleAllNegative = { -3, -5, -7 };

int maxValue = FindMax(sampleAllNegative);
Console.WriteLine("El valor máximo es: " + maxValue);

Console.WriteLine("****************************");
// 6 Tener el promedio

static void GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    int avg = sum / numbers.Length;
    Console.WriteLine(avg);
}

int[] sampleArray = { 2, 10, 3 };
GetAverage(sampleArray);

Console.WriteLine("****************************");
// 7 Lista con números impares​

static List<int> OddList()
{
    List<int> oddNumbers = new List<int>();

    for (int i = 1; i <= 255; i += 2)
    {
        oddNumbers.Add(i);
    }

    return oddNumbers;
}
List<int> oddNumbersList = OddList();
Console.WriteLine(string.Join(", ", oddNumbersList));

Console.WriteLine("****************************");

// 8 Mayor que Y​ 

static int GreaterThanY(List<int> numbers, int y)
{
    int count = 0;

    foreach (int num in numbers)
    {
        if (num > y)
        {
            count++;
        }
    }

    return count;
}


List<int> numbersList = new List<int> { 1, 3, 5, 7 };
int y = 3;

int count = GreaterThanY(numbersList, y);
Console.WriteLine("Número de valores mayores que " + y + ": " + count);

Console.WriteLine("****************************");

// 9 Cuadrar los Valores​

static void SquareArrayValues(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * numbers[i];
    }
}

int[] samples = { 2, 4, 6, 8, 10 };
int[] sampleAllNegativeValue = { -3, -5, -7 };

SquareArrayValues(samples);
SquareArrayValues(sampleAllNegativeValue);

foreach (int num in samples)
{
    Console.WriteLine(num);
}

foreach (int num in sampleAllNegativeValue)
{
    Console.WriteLine(num);
}

Console.WriteLine("****************************");

// 10  Elimina los Números Negativos​

static void EliminateNegatives(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
            numbers[i] = 0;
        else
            numbers[i] = numbers[i];
        
    }
}
List<int> numbersListDelete = new List<int> { 1, 5, 10, -2 };
EliminateNegatives(numbersListDelete);

foreach (int num in numbersListDelete)
{
    Console.WriteLine(num);
}



