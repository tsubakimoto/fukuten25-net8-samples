// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** TimeProvider Sample ***");

DateTimeOffset utcNow = TimeProvider.System.GetUtcNow();
DateTimeOffset localNow = TimeProvider.System.GetLocalNow();

Console.WriteLine($"UTC Now:\t{utcNow}");
Console.WriteLine($"JST Now:\t{localNow}");

ITimeProvider timeProvider = new ZonedTimeProvider();
Console.WriteLine($"PST Time:\t{timeProvider.GetLocalNow()}");
