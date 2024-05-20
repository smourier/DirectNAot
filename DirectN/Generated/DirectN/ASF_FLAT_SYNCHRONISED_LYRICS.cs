#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-asf_flat_synchronised_lyrics
[StructLayout(LayoutKind.Sequential)]
public partial struct ASF_FLAT_SYNCHRONISED_LYRICS
{
    public byte bTimeStampFormat;
    public byte bContentType;
    public uint dwLyricsLen;
}
