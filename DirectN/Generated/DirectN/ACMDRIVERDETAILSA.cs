#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMDRIVERDETAILSA
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
    public InlineArrayFoundationCHAR_32 szShortName;
    public InlineArrayFoundationCHAR_128 szLongName;
    public InlineArrayFoundationCHAR_80 szCopyright;
    public InlineArrayFoundationCHAR_128 szLicensing;
    public InlineArrayFoundationCHAR_512 szFeatures;
}
