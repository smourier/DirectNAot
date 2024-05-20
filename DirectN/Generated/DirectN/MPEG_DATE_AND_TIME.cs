#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_date_and_time
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG_DATE_AND_TIME
{
    public MPEG_DATE D;
    public MPEG_TIME T;
}
