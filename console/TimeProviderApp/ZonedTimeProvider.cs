internal class ZonedTimeProvider : TimeProvider
{
    static TimeZoneInfo _jpnZoneInfo;
    static TimeZoneInfo _usZoneInfo;
    private TimeZoneInfo _zoneInfo;

    static ZonedTimeProvider()
    {
        try
        {
            _jpnZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            _usZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        }
        catch
        {
            _jpnZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
            _usZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("America/Los_Angeles");
        }
    }
    public ZonedTimeProvider(TimeZoneInfo? zoneInfo = null) : base()
    {
        _zoneInfo = zoneInfo ?? _usZoneInfo;
    }

    public override TimeZoneInfo LocalTimeZone { get => _zoneInfo; }
    public static TimeProvider FromLocalTimeZone(TimeZoneInfo zoneInfo) => new ZonedTimeProvider(zoneInfo);
}
