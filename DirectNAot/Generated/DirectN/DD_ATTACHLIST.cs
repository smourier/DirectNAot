#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_attachlist
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_ATTACHLIST
{
    public nint lpLink;
    public nint lpAttached;
}
