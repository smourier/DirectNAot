#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_ETHERNET_ADDRESS_LIST
{
    public uint ulcAddresses;
    public InlineArrayBDA_ETHERNET_ADDRESS1 rgAddressl; // variable-length array placeholder
}
