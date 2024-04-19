namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_ETHERNET_ADDRESS
{
    public InlineArrayByte6 rgbAddress;
}
