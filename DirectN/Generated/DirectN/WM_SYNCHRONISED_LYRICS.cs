#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_synchronised_lyrics
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WM_SYNCHRONISED_LYRICS
{
    public byte bTimeStampFormat;
    public byte bContentType;
    public PWSTR pwszContentDescriptor;
    public uint dwLyricsLen;
    public nint pbLyrics;
}
