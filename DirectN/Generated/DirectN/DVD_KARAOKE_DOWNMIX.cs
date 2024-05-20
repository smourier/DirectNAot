#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-dvd_karaoke_downmix
public enum DVD_KARAOKE_DOWNMIX
{
    DVD_Mix_0to0 = 1,
    DVD_Mix_1to0 = 2,
    DVD_Mix_2to0 = 4,
    DVD_Mix_3to0 = 8,
    DVD_Mix_4to0 = 16,
    DVD_Mix_Lto0 = 32,
    DVD_Mix_Rto0 = 64,
    DVD_Mix_0to1 = 256,
    DVD_Mix_1to1 = 512,
    DVD_Mix_2to1 = 1024,
    DVD_Mix_3to1 = 2048,
    DVD_Mix_4to1 = 4096,
    DVD_Mix_Lto1 = 8192,
    DVD_Mix_Rto1 = 16384,
}
