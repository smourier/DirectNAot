#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_IPv4_ADDRESS_LIST
{
    public uint ulcAddresses;
    public InlineArrayBDA_IPv4_ADDRESS1 rgAddressl; // variable-length array placeholder
}
