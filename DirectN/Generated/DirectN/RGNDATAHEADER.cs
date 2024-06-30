#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-rgndataheader
public partial struct RGNDATAHEADER
{
    public uint dwSize;
    public uint iType;
    public uint nCount;
    public uint nRgnSize;
    public RECT rcBound;
}
