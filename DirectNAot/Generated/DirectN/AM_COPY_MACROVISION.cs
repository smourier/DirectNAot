#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_copy_macrovision
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_COPY_MACROVISION
{
    public uint MACROVISIONLevel;
}
