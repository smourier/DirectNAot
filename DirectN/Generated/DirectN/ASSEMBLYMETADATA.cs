#nullable enable
namespace DirectN;

public partial struct ASSEMBLYMETADATA
{
    public ushort usMajorVersion;
    public ushort usMinorVersion;
    public ushort usBuildNumber;
    public ushort usRevisionNumber;
    public PWSTR szLocale;
    public uint cbLocale;
    public nint rProcessor;
    public uint ulProcessor;
    public nint rOS;
    public uint ulOS;
}
