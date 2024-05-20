#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_set_copy_state
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVDCOPY_SET_COPY_STATE
{
    public uint DVDCopyState;
}
