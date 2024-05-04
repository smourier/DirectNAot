#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ImageCodecInfo
{
    public Guid Clsid;
    public Guid FormatID;
    public PWSTR CodecName;
    public PWSTR DllName;
    public PWSTR FormatDescription;
    public PWSTR FilenameExtension;
    public PWSTR MimeType;
    public uint Flags;
    public uint Version;
    public uint SigCount;
    public uint SigSize;
    public nint SigPattern;
    public nint SigMask;
}
