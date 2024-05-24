#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMFILTERDETAILSA
{
    public uint cbStruct;
    public uint dwFilterIndex;
    public uint dwFilterTag;
    public uint fdwSupport;
    public nint pwfltr;
    public uint cbwfltr;
    public InlineArrayFoundationCHAR_128 szFilter;
}
