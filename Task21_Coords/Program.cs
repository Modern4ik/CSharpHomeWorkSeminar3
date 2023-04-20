// Поиск расстояния между двумя точками в 3D пространстве.

Console.Clear();

int x1, y1, z1, x2, y2, z2;

try
{
    Console.Write("Введите X1: ");
    x1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Y1: ");
    y1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Z1: ");
    z1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите X2: ");
    x2 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Y2 ");
    y2 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Z2: ");
    z2 = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception)
{
    Console.WriteLine($"Ошибка ввода данных! Повторите попытку!");
    return;
}

double distance = GetDistanceByCoords(x1, y1, z1, x2, y2, z2);
PrintResult(distance);

/////////////////////////////////////////////////////////////////////////////

double GetDistanceByCoords(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int coord1 = x2 - x1;
    int coord2 = y2 - y1;
    int coord3 = z2 - z1;
    double distance = Math.Sqrt(coord1 * coord1 + coord2 * coord2 + coord3 * coord3);
    return distance;
}

void PrintResult(double distance)
{
    Console.WriteLine($"Дистанция между данными точками в 3D пространстве = {distance}");
}
