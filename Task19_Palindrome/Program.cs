// Проверка пятизначного числа на палиндром.

Console.Clear();
int numb = GetNumberFromUser("Введите пятизначное число: ", "Ошибка ввода!Повторите попытку!");
CheckNumberForPalindrome(numb);




////////////////////////////////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 9999 && userNumber < 100000)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int CheckNumberForPalindrome(int number)
{
    int firstHalfOfNumber = number / 1000;
    int secondHalfOfNumber = number % 100;
    int numb1 = firstHalfOfNumber / 10;
    int numb2 = firstHalfOfNumber % 10;
    int numb3 = secondHalfOfNumber / 10;
    int numb4 = secondHalfOfNumber % 10;

    if (numb1 == numb4 && numb2 == numb3)
    {
        Console.WriteLine($"{number} - является палиндромом.");
    }
    else
    {
        Console.WriteLine($"{number} - не является палиндромом.");
    }
    return number;
}
