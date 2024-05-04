#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavdecvideoswpowerlevel
public enum eAVDecVideoSWPowerLevel
{
    eAVDecVideoSWPowerLevel_BatteryLife = 0,
    eAVDecVideoSWPowerLevel_Balanced = 50,
    eAVDecVideoSWPowerLevel_VideoQuality = 100,
}
