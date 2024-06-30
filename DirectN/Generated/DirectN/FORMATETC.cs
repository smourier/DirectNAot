#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-formatetc
public partial struct FORMATETC
{
    public ushort cfFormat;
    public nint ptd;
    public uint dwAspect;
    public int lindex;
    public uint tymed;
}
