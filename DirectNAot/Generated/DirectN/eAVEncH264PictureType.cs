#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavench264picturetype
public enum eAVEncH264PictureType
{
    eAVEncH264PictureType_IDR = 0,
    eAVEncH264PictureType_P = 1,
    eAVEncH264PictureType_B = 2,
}
