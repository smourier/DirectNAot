#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
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
    public InlineArrayFoundationCHAR32 szShortName;
    public InlineArrayFoundationCHAR128 szLongName;
    public InlineArrayFoundationCHAR80 szCopyright;
    public InlineArrayFoundationCHAR128 szLicensing;
    public InlineArrayFoundationCHAR512 szFeatures;
}
