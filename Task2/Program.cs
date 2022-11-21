/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


double x1 = UserInput("Введите коориднату х для точки A: ");
double y1 = UserInput("Введите коориднату y для точки A: ");
double z1 = UserInput("Введите коориднату z для точки A: ");
double x2 = UserInput("Введите коориднату х для точки B: ");
double y2 = UserInput("Введите коориднату y для точки B: ");
double z2 = UserInput("Введите коориднату z для точки B: ");

Distance(x1, y1, z1, x2, y2, z2);

double UserInput(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine()??"");
}

static void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {result}");
}