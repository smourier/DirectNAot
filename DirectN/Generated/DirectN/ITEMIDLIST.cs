#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-itemidlist
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ITEMIDLIST
{
    public SHITEMID mkid;
}
