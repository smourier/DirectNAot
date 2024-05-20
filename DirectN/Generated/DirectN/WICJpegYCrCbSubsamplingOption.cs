#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicjpegycrcbsubsamplingoption
public enum WICJpegYCrCbSubsamplingOption
{
    WICJpegYCrCbSubsamplingDefault = 0,
    WICJpegYCrCbSubsampling420 = 1,
    WICJpegYCrCbSubsampling422 = 2,
    WICJpegYCrCbSubsampling444 = 3,
    WICJpegYCrCbSubsampling440 = 4,
}
