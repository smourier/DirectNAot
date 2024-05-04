#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavdecvideosoftwaredeinterlacemode
public enum eAVDecVideoSoftwareDeinterlaceMode
{
    eAVDecVideoSoftwareDeinterlaceMode_NoDeinterlacing = 0,
    eAVDecVideoSoftwareDeinterlaceMode_ProgressiveDeinterlacing = 1,
    eAVDecVideoSoftwareDeinterlaceMode_BOBDeinterlacing = 2,
    eAVDecVideoSoftwareDeinterlaceMode_SmartBOBDeinterlacing = 3,
}
