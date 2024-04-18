namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/t2embapi/ns-t2embapi-ttvalidationtestsparams
[StructLayout(LayoutKind.Sequential)]
public partial struct TTVALIDATIONTESTSPARAMS
{
    public uint ulStructSize;
    public int lTestFromSize;
    public int lTestToSize;
    public uint ulCharSet;
    public ushort usReserved1;
    public ushort usCharCodeCount;
    public nint pusCharCodeSet;
}
