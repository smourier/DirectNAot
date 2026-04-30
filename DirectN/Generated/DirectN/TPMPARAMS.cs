#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-tpmparams
public partial struct TPMPARAMS
{
    public uint cbSize;
    public RECT rcExclude;
}
