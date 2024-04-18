namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/t2embapi/ns-t2embapi-ttembedinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct TTEMBEDINFO
{
    public ushort usStructSize;
    public ushort usRootStrSize;
    public nint pusRootStr;
}
