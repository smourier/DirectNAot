namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-abc
[StructLayout(LayoutKind.Sequential)]
public partial struct ABC
{
    public int abcA;
    public uint abcB;
    public int abcC;
}
