namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFILTERDETAILSW
{
    public uint cbStruct;
    public uint dwFilterIndex;
    public uint dwFilterTag;
    public uint fdwSupport;
    public nint pwfltr;
    public uint cbwfltr;
    public InlineArraySystemChar128 szFilter;
}
