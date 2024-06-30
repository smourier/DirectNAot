#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_palettecallbacks
public partial struct DD_PALETTECALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint DestroyPalette;
    public nint SetEntries;
}
