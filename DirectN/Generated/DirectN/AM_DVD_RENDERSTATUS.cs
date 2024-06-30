#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-am_dvd_renderstatus
public partial struct AM_DVD_RENDERSTATUS
{
    public HRESULT hrVPEStatus;
    public BOOL bDvdVolInvalid;
    public BOOL bDvdVolUnknown;
    public BOOL bNoLine21In;
    public BOOL bNoLine21Out;
    public int iNumStreams;
    public int iNumStreamsFailed;
    public uint dwFailedStreamsFlag;
}
