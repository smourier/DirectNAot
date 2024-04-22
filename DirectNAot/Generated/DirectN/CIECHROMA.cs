namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-ciechroma
[StructLayout(LayoutKind.Sequential)]
public partial struct CIECHROMA
{
    public int x;
    public int y;
    public int Y;
}
