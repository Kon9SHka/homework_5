Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ");
double [] TrueArray = GetArray(size);
double MaxNumber = MaxAndMinFind(TrueArray,1);
double MinNumber = MaxAndMinFind(TrueArray,0);
Console.WriteLine($"Разница между {MaxNumber} и {MinNumber} -> {MaxNumber-MinNumber}");

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

double[] GetArray (int sizeArray) 
{   
    double[] array = new double[sizeArray];
    double number = 0;
    Console.Write($"Массив: [");
    for (int i = 0; i < sizeArray; i++)
    {
        number = new Random().NextDouble()*100;
        array[i]= Math.Round(number,2);
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine("]");
    return array;
}

double MaxAndMinFind (double[] array, int flag) 
{   
    double number = array[0];
    if (flag == 1) 
    {
    Console.Write($"Максимальное число: ");
    foreach (double el in array) 
        {
        if (el > number) 
        number = el;
        }
    Console.WriteLine($"{number}");
    return number;
    }
    else
    {
    Console.Write($"Минимальное число: ");
    foreach (double el in array) 
        {
        if (el < number) 
        number = el;
        }
    Console.WriteLine($"{number}");
    return number;
    }
}
