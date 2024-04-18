namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_kerningpair
[StructLayout(LayoutKind.Sequential)]
public partial struct FD_KERNINGPAIR
{
    public char wcFirst;
    public char wcSecond;
    public short fwdKern;
}
