namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-xyzcolor
[StructLayout(LayoutKind.Sequential)]
public partial struct XYZCOLOR
{
    public ushort X;
    public ushort Y;
    public ushort Z;
}
