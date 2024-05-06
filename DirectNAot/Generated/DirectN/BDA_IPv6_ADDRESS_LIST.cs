#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_IPv6_ADDRESS_LIST
{
    public uint ulcAddresses;
    public InlineArrayBDA_IPv6_ADDRESS_1 rgAddressl; // variable-length array placeholder
}
