namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-kerningpair
[StructLayout(LayoutKind.Sequential)]
public partial struct KERNINGPAIR
{
    public ushort wFirst;
    public ushort wSecond;
    public int iKernAmount;
}
