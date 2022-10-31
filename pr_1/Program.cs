Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ");
int minValue = GetNumberFromUser("Введите минимальную границу: ");
int maxValue = GetNumberFromUser("Введите максимальную границу: ");
int[] TrueArray = GetArray(size, minValue, maxValue);
CountPositiveNumbers(TrueArray);


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

static void CountPositiveNumbers(int[] array) 
{
    int CountPositive = 0;
    Console.Write($"Массив: [");
    foreach(int el in array)
        {
            Console.Write($"{el} ");
            if(el%2==0) 
            {
                CountPositive = CountPositive + 1;
            }
        }
    Console.WriteLine("]");
    Console.WriteLine($"Кол-во четных чисел: {CountPositive}");
}