public class Task5
{
    public static void Main()
    {
        DateTime birthdate = new DateTime(2005, 06, 29);
        DateTime currentDate = DateTime.Now;
        
        TimeSpan age = currentDate - birthdate;
        
        Console.WriteLine($"Birthdate: {birthdate}");
        Console.WriteLine($"Current date: {currentDate}");
        Console.WriteLine($"Age in days: {age.Days}");
        
        DateTime newDate = birthdate.AddDays(10);

        Console.WriteLine($"Birthdate after 10 days: {newDate}");
    }
} 