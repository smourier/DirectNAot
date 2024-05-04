#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct tACMFORMATDETAILSW
{
    public uint cbStruct;
    public uint dwFormatIndex;
    public uint dwFormatTag;
    public uint fdwSupport;
    public nint pwfx;
    public uint cbwfx;
    public InlineArraySystemChar128 szFormat;
}
