#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_kerningpair
public partial struct FD_KERNINGPAIR
{
    public char wcFirst;
    public char wcSecond;
    public short fwdKern;
}
