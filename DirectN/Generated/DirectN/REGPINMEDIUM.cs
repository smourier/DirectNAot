#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-regpinmedium
public partial struct REGPINMEDIUM
{
    public Guid clsMedium;
    public uint dw1;
    public uint dw2;
}
