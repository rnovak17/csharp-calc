double Calculate(int selection, double x, double y)
{
    double answer = 0.0;
    switch (selection)
    {
        case 1:
            answer = (x + y);
            break;
        case 2:
            answer = (x - y);
            break;
        case 3:
            answer = (x * y);
            break;
        case 4:
            answer = (x / y);
            break;
        default:
            Console.WriteLine("Please select a valid operation.");
            break;
    }
    return answer;
}


// print operator choices to user
Console.WriteLine("Select operator: \n 1. Addition \n 2. Subtraction \n 3. " +
    "Multiplication \n 4. Division");

// ensure input only accepts integer values, from 1-4
bool isValid = false;
int selection = 0;
while (isValid == false) {
    // take user selection for operator
    string? opNum = Console.ReadLine();

    // check if the user input is valid
    if (int.TryParse(opNum, out selection) && int.Parse(opNum) > 0 && int.Parse(opNum) <= 4)
    {
        // set condition to break the loop
        isValid = true;
    }
    else
    {
        Console.WriteLine("Please input an integer between 1 and 4");
    }    
}

// take user input for operands
Console.WriteLine("x: ");
string? xStr = Console.ReadLine();
double x = Convert.ToDouble(xStr);

Console.WriteLine("y: ");
string? yStr = Console.ReadLine();
double y = Convert.ToDouble(yStr);

// process user's inputs
double output = Calculate(selection, x, y);

// print output to user and wait to close prompt
Console.WriteLine($"{Convert.ToString(output)}");
Thread.Sleep(3000);