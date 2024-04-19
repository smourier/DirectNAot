namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_sampleformat
public enum DXVA2_SampleFormat
{
    DXVA2_SampleFormatMask = 255,
    DXVA2_SampleUnknown = 0,
    DXVA2_SampleProgressiveFrame = 2,
    DXVA2_SampleFieldInterleavedEvenFirst = 3,
    DXVA2_SampleFieldInterleavedOddFirst = 4,
    DXVA2_SampleFieldSingleEven = 5,
    DXVA2_SampleFieldSingleOdd = 6,
    DXVA2_SampleSubStream = 7,
}
