namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFORMATDETAILSA
{
    public uint cbStruct;
    public uint dwFormatIndex;
    public uint dwFormatTag;
    public uint fdwSupport;
    public nint pwfx;
    public uint cbwfx;
    public InlineArrayFoundationCHAR128 szFormat;
}
