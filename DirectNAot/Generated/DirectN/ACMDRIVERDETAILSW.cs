#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
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
    public InlineArraySystemChar32 szShortName;
    public InlineArraySystemChar128 szLongName;
    public InlineArraySystemChar80 szCopyright;
    public InlineArraySystemChar128 szLicensing;
    public InlineArraySystemChar512 szFeatures;
}
