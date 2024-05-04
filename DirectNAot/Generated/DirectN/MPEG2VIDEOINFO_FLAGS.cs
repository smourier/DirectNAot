#nullable enable
namespace DirectN;

[Flags]
public enum MPEG2VIDEOINFO_FLAGS : uint
{
    AMMPEG2_DoPanScan = 1,
    AMMPEG2_DVDLine21Field1 = 2,
    AMMPEG2_DVDLine21Field2 = 4,
    AMMPEG2_SourceIsLetterboxed = 8,
    AMMPEG2_FilmCameraMode = 16,
    AMMPEG2_LetterboxAnalogOut = 32,
    AMMPEG2_DSS_UserData = 64,
    AMMPEG2_DVB_UserData = 128,
    AMMPEG2_27MhzTimebase = 256,
    AMMPEG2_WidescreenAnalogOut = 512,
}
