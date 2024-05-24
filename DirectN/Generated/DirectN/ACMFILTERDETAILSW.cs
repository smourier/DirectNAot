#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMFILTERDETAILSW
{
    public uint cbStruct;
    public uint dwFilterIndex;
    public uint dwFilterTag;
    public uint fdwSupport;
    public nint pwfltr;
    public uint cbwfltr;
    public InlineArraySystemChar_128 szFilter;
}
