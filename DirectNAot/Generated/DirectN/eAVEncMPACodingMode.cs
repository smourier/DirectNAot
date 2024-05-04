#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencmpacodingmode
public enum eAVEncMPACodingMode
{
    eAVEncMPACodingMode_Mono = 0,
    eAVEncMPACodingMode_Stereo = 1,
    eAVEncMPACodingMode_DualChannel = 2,
    eAVEncMPACodingMode_JointStereo = 3,
    eAVEncMPACodingMode_Surround = 4,
}
