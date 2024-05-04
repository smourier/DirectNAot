#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdkaraokedata
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DvdKaraokeData
{
    public uint dwDownmix;
    public uint dwSpeakerAssignment;
}
