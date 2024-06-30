#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_mua_mixinginfo
public partial struct DVD_MUA_MixingInfo
{
    public BOOL fMixTo0;
    public BOOL fMixTo1;
    public BOOL fMix0InPhase;
    public BOOL fMix1InPhase;
    public uint dwSpeakerPosition;
}
