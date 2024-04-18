namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/t2embapi/ns-t2embapi-ttvalidationtestsparamsex
[StructLayout(LayoutKind.Sequential)]
public partial struct TTVALIDATIONTESTSPARAMSEX
{
    public uint ulStructSize;
    public int lTestFromSize;
    public int lTestToSize;
    public uint ulCharSet;
    public ushort usReserved1;
    public ushort usCharCodeCount;
    public nint pulCharCodeSet;
}
