#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-pathdata
public partial struct PATHDATA
{
    public uint flags;
    public uint count;
    public nint pptfx;
}
