#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_audioattributes
public partial struct DVD_AudioAttributes
{
    public DVD_AUDIO_APPMODE AppMode;
    public byte AppModeData;
    public DVD_AUDIO_FORMAT AudioFormat;
    public uint Language;
    public DVD_AUDIO_LANG_EXT LanguageExtension;
    public BOOL fHasMultichannelInfo;
    public uint dwFrequency;
    public byte bQuantization;
    public byte bNumberOfChannels;
    public InlineArrayUInt32_2 dwReserved;
}
