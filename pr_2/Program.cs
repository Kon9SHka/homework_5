Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ");
int minValue = GetNumberFromUser("Введите минимальную границу: ");
int maxValue = GetNumberFromUser("Введите максимальную границу: ");
int[] TrueArray = GetArray(size, minValue, maxValue);
SumOfPossitiveEl(TrueArray);
//////////////////////////////////////////////////////////////////////////
int GetNumberFromUser (string message) 
{
    while(true) 
    {

        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        while(isCorrect)
            return number;
        Console.WriteLine("Ошибка ввода!");
    }
}

int[] GetArray (int sizeArray, int minValue, int maxValue) 
{   
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
    }
    return array;
}

static void SumOfPossitiveEl(int[] array) 
{
    int SumNegative = 0;
    Console.Write($"Массив: [");
    for (int i = 0; i < array.Length; i ++) 
    {
        Console.Write($" {array[i]} ");
        if (i%2 != 0) 
        SumNegative = SumNegative + array[i];
    }
    Console.WriteLine("]");
    Console.WriteLine($"Кол-во четных чисел: {SumNegative}");
}