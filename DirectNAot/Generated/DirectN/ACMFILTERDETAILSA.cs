#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFILTERDETAILSA
{
    public uint cbStruct;
    public uint dwFilterIndex;
    public uint dwFilterTag;
    public uint fdwSupport;
    public nint pwfltr;
    public uint cbwfltr;
    public InlineArrayFoundationCHAR128 szFilter;
}
