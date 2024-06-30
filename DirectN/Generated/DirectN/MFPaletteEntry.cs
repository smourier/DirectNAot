#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfpaletteentry
[StructLayout(LayoutKind.Explicit)]
public partial struct MFPaletteEntry
{
    [FieldOffset(0)]
    public MFARGB ARGB;
    
    [FieldOffset(0)]
    public MFAYUVSample AYCbCr;
}
