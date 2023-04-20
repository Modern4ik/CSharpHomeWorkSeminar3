// Поиск кубов чисел в заданном пределе N.

Console.Clear();

int numb = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!Повторите попытку!");
GetCubesByUserNumber(numb);

/////////////////////////////////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetCubesByUserNumber(int number)
{
    double cubes;
    for (int i = 1; i <= number; i++)
    {
        cubes = Math.Pow(i, 3);
        Console.Write($"{cubes} ");
    }
    return number;
}
