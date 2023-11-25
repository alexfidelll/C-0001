int firstValue = int.Parse(args[0]);
int lastValue = int.Parse(args[2]);

switch (args[1])
{
	case "+":
        Console.WriteLine(firstValue + lastValue);
        break;
    case "-":
        Console.WriteLine(firstValue - lastValue);
        break;
    case "/":
        if (firstValue == 0 && lastValue == 0)
        {
            Console.WriteLine("Делить на 0 нельзя");
            break;
        }
        Console.WriteLine(firstValue / lastValue);
        break;
    case "*":
        Console.WriteLine(firstValue * lastValue);
        break;

}