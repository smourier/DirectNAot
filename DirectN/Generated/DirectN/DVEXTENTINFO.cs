#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-dvextentinfo
public partial struct DVEXTENTINFO
{
    public uint cb;
    public uint dwExtentMode;
    public SIZE sizelProposed;
}
