#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencmpvscenedetection
public enum eAVEncMPVSceneDetection
{
    eAVEncMPVSceneDetection_None = 0,
    eAVEncMPVSceneDetection_InsertIPicture = 1,
    eAVEncMPVSceneDetection_StartNewGOP = 2,
    eAVEncMPVSceneDetection_StartNewLocatableGOP = 3,
}
