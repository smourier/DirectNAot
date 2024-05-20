#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencvideocolorlighting
public enum eAVEncVideoColorLighting
{
    eAVEncVideoColorLighting_SameAsSource = 0,
    eAVEncVideoColorLighting_Unknown = 1,
    eAVEncVideoColorLighting_Bright = 2,
    eAVEncVideoColorLighting_Office = 3,
    eAVEncVideoColorLighting_Dim = 4,
    eAVEncVideoColorLighting_Dark = 5,
}
