namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/t2embapi/ns-t2embapi-ttloadinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct TTLOADINFO
{
    public ushort usStructSize;
    public ushort usRefStrSize;
    public nint pusRefStr;
}
