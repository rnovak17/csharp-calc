double Add(double x, double y)
{
    return x + y;
}

double Subtract(double x, double y)
{
    return x - y;
}

double Multiply(double x, double y)
{
    return x * y;
}

double Divide(double x, double y)
{
    return x / y;
}


Console.WriteLine("Select operator: \n 1. Addition \n 2. Subtraction \n 3. " +
    "Multiplication \n 4. Division");
// TODO: make this reject non integers (tryparse, returns T/F)
// TODO: make this reject numbers greater or lesser than possible options
int opNum = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("x: ");
string? xStr = Console.ReadLine();
double x = Convert.ToDouble(xStr);

Console.WriteLine("y: ");
string? yStr = Console.ReadLine();
double y = Convert.ToDouble(yStr);

double answer = 0.0;
switch (opNum)
{
    case 1:
        answer = Add(x, y);
        break;
    case 2:
         answer = Subtract(x, y);
        break;
    case 3:
        answer = Multiply(x, y);
        break;
    case 4:
        answer = Divide(x, y);
        break;
    default:
        Console.WriteLine("Please select a valid operation.");
        break;
}
Console.WriteLine($"{Convert.ToString(answer)}");
Thread.Sleep(3000);