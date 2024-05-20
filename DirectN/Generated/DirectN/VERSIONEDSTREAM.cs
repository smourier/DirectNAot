#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VERSIONEDSTREAM
{
    public Guid guidVersion;
    public nint pStream;
}
