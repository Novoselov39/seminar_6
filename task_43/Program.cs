Console.Clear();


Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
bool stat= true;
if (k1 == k2) 
{
        Console.WriteLine("Прямые параллельны!!");
        stat=false;
        
}

double[] FindCoordinates(double b1, double k1, double b2, double k2)
{
    //y = k1 * x + b1, y = k2 * x + b2
    double[] cord = new double[2];    
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    cord[0] = x;
    cord[1] = y;
    return cord;
}

if (stat) Console.WriteLine($" Координаты [{String.Join(" ", FindCoordinates(b1, k1, b2, k2))}]");