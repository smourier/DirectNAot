#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BRIGHTNESS_LEVEL
{
    public byte Count;
    public InlineArrayByte_103 Level;
}
