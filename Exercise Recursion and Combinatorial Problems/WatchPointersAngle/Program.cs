class Program
{
    static void Main()
    {
        int hour = 5;
        int minute = 0;

        double angle = CalculateClockAngle(hour, minute);

        Console.WriteLine($"По - малкия ъгъл между стрелките е: {angle} градуса");
    }

    static double CalculateClockAngle(int hour, int minute)
    {
        int angleHour = hour * 30 + minute / 2;
        int angleMinute = minute * 6;

        
        return Math.Min(Math.Abs(angleMinute + angleHour), 360 - Math.Abs(angleMinute + angleHour));
    }
}
