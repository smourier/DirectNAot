namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_multichannelaudioattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_MultichannelAudioAttributes
{
    public InlineArrayDVD_MUA_MixingInfo8 Info;
    public InlineArrayDVD_MUA_Coeff8 Coeff;
}
