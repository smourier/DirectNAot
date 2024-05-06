#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_ETHERNET_ADDRESS
{
    public InlineArrayByte_6 rgbAddress;
}
