#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfvideosurfaceinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoSurfaceInfo
{
    public uint Format;
    public uint PaletteEntries;
    public InlineArrayMFPaletteEntry_1 Palette; // variable-length array placeholder
}
