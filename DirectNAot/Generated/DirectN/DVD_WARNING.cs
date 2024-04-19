namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdevcod/ne-dvdevcod-dvd_warning
public enum DVD_WARNING
{
    DVD_WARNING_InvalidDVD1_0Disc = 1,
    DVD_WARNING_FormatNotSupported = 2,
    DVD_WARNING_IllegalNavCommand = 3,
    DVD_WARNING_Open = 4,
    DVD_WARNING_Seek = 5,
    DVD_WARNING_Read = 6,
}
