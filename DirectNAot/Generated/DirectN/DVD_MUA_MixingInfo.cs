#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_mua_mixinginfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_MUA_MixingInfo
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fMixTo0;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fMixTo1;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fMix0InPhase;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fMix1InPhase;
    public uint dwSpeakerPosition;
}
