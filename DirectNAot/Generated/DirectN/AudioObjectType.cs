namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/ne-spatialaudioclient-audioobjecttype
public enum AudioObjectType
{
    AudioObjectType_None = 0,
    AudioObjectType_Dynamic = 1,
    AudioObjectType_FrontLeft = 2,
    AudioObjectType_FrontRight = 4,
    AudioObjectType_FrontCenter = 8,
    AudioObjectType_LowFrequency = 16,
    AudioObjectType_SideLeft = 32,
    AudioObjectType_SideRight = 64,
    AudioObjectType_BackLeft = 128,
    AudioObjectType_BackRight = 256,
    AudioObjectType_TopFrontLeft = 512,
    AudioObjectType_TopFrontRight = 1024,
    AudioObjectType_TopBackLeft = 2048,
    AudioObjectType_TopBackRight = 4096,
    AudioObjectType_BottomFrontLeft = 8192,
    AudioObjectType_BottomFrontRight = 16384,
    AudioObjectType_BottomBackLeft = 32768,
    AudioObjectType_BottomBackRight = 65536,
    AudioObjectType_BackCenter = 131072,
}
