#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EncoderParameters
{
    public uint Count;
    public InlineArrayEncoderParameter1 Parameter; // variable-length array placeholder
}
