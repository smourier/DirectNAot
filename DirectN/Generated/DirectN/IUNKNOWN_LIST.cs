#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct IUNKNOWN_LIST
{
    public nint lpLink;
    public nint lpGuid;
    public nint lpIUnknown;
}
