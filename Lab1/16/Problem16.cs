using System;
public class Problem16
{
    public static void Main() => Console.WriteLine(Console.ReadLine() switch
    {
        "1" => "Monday",
        "2" => "Tuesday",
        "3" => "Wednesday",
        "4" => "Thursday",
        "5" => "Friday",
        "6" => "Saturday",
        "7" => "Sunday",
        _ => "Not valid"
    });
}