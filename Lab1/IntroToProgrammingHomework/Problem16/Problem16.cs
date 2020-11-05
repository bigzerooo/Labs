using System;
class Problem16
{
    static void Main()
    {
        string result;
        switch (Console.ReadLine())
        {
            case "1":
                result = "Monday";
                break;
            case "2":
                result = "Tuesday";
                break;
            case "3":
                result = "Wednesday";
                break;
            case "4":
                result = "Thursday";
                break;
            case "5":
                result = "Friday";
                break;
            case "6":
                result = "Saturday";
                break;
            case "7":
                result = "Sunday";
                break;
            default:
                result = "Not valid";
                break;
        }
        Console.WriteLine(result);        
    }
}