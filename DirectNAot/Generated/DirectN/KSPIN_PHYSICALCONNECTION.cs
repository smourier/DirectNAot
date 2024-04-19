namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPIN_PHYSICALCONNECTION
{
    public uint Size;
    public uint Pin;
    public InlineArraySystemChar1 SymbolicLinkName; // variable-length array placeholder
}
