#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-eng_time_fields
public partial struct ENG_TIME_FIELDS
{
    public ushort usYear;
    public ushort usMonth;
    public ushort usDay;
    public ushort usHour;
    public ushort usMinute;
    public ushort usSecond;
    public ushort usMilliseconds;
    public ushort usWeekday;
}
