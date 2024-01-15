namespace CollectionViewPerfIssues.Data;

public record EventItem
{
    private static Random rand = new Random();
    
    public string LogLevel { get; init; }
    public DateTime EventTime { get; init; }
    public string EventTimeString { get; init; }
    public string Message { get; init; }

    public EventItem(string logLevel, string message)
    {
        LogLevel = logLevel;
        Message = message;

        EventTime = DateTime.Now;
        EventTimeString = EventTime.ToString("h:mm:ss tt");
    }

    public static EventItem GenerateEventWithRandomMessage()
    {
        return new EventItem("INFO", rand.Next(1_000_000, 9_999_999).ToString());
    }
}