#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencadaptivemode
public enum eAVEncAdaptiveMode
{
    eAVEncAdaptiveMode_None = 0,
    eAVEncAdaptiveMode_Resolution = 1,
    eAVEncAdaptiveMode_FrameRate = 2,
}
