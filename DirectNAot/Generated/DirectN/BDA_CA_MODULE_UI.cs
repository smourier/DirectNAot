namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_CA_MODULE_UI
{
    public uint ulFormat;
    public uint ulbcDesc;
    public InlineArrayUInt321 ulDesc; // variable-length array placeholder
}
