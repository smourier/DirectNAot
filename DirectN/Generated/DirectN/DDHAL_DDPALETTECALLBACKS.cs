#nullable enable
namespace DirectN;

public partial struct DDHAL_DDPALETTECALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint DestroyPalette;
    public nint SetEntries;
}
