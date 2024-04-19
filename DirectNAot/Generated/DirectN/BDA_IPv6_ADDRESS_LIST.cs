namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_IPv6_ADDRESS_LIST
{
    public uint ulcAddresses;
    public InlineArrayBDA_IPv6_ADDRESS1 rgAddressl; // variable-length array placeholder
}
