#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct tACMFORMATDETAILSW
{
    public uint cbStruct;
    public uint dwFormatIndex;
    public uint dwFormatTag;
    public uint fdwSupport;
    public nint pwfx;
    public uint cbwfx;
    public InlineArraySystemChar_128 szFormat;
}
