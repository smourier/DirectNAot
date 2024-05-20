#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSDISPLAYCHANGE
{
    public uint PelsWidth;
    public uint PelsHeight;
    public uint BitsPerPel;
    public InlineArraySystemChar_1 DeviceID; // variable-length array placeholder
}
