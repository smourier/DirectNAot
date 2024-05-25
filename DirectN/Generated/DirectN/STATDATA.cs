#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-statdata
[StructLayout(LayoutKind.Sequential)]
public partial struct STATDATA
{
    public FORMATETC formatetc;
    public uint advf;
    public nint pAdvSink;
    public uint dwConnection;
}
