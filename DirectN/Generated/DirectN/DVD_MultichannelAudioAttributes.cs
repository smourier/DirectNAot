#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_multichannelaudioattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_MultichannelAudioAttributes
{
    public InlineArrayDVD_MUA_MixingInfo_8 Info;
    public InlineArrayDVD_MUA_Coeff_8 Coeff;
}
