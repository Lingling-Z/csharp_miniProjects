public static class ConsoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";
        while(string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }
        return output;
    }

    public static int RequestInt(this string message)
    {
        return message.RequestInt(false);
    }

    public static int RequestInt(this string message, int min, int max)
    {
        return message.RequestInt(true, min, max);
    }

    public static int RequestInt(this string message, bool useMinMax, int min=0, int max=0)
    {
        int output = 0;
        bool isValidRange = true;
        bool isValidInt = false;

        do
        {
            Console.Write(message);
            isValidInt = int.TryParse(Console.ReadLine(), out output);
            if (useMinMax == true)
            {
                isValidRange = (output >= min && output <= max);
            } 
        }while(isValidRange == false || isValidInt == false);
        return output;
    }
}