#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMDRIVERDETAILSW
{
    public uint cbStruct;
    public uint fccType;
    public uint fccComp;
    public ushort wMid;
    public ushort wPid;
    public uint vdwACM;
    public uint vdwDriver;
    public uint fdwSupport;
    public uint cFormatTags;
    public uint cFilterTags;
    public HICON hicon;
    public InlineArraySystemChar_32 szShortName;
    public InlineArraySystemChar_128 szLongName;
    public InlineArraySystemChar_80 szCopyright;
    public InlineArraySystemChar_128 szLicensing;
    public InlineArraySystemChar_512 szFeatures;
}
