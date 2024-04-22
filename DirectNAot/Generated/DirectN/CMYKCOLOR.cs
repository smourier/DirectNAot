namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-cmykcolor
[StructLayout(LayoutKind.Sequential)]
public partial struct CMYKCOLOR
{
    public ushort cyan;
    public ushort magenta;
    public ushort yellow;
    public ushort black;
}
