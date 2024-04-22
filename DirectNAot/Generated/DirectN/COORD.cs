namespace DirectN;

// https://learn.microsoft.com/windows/console/coord-str
[StructLayout(LayoutKind.Sequential)]
public partial struct COORD
{
    public short X;
    public short Y;
}
