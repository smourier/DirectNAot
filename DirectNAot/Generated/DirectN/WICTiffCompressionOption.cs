#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wictiffcompressionoption
public enum WICTiffCompressionOption
{
    WICTiffCompressionDontCare = 0,
    WICTiffCompressionNone = 1,
    WICTiffCompressionCCITT3 = 2,
    WICTiffCompressionCCITT4 = 3,
    WICTiffCompressionLZW = 4,
    WICTiffCompressionRLE = 5,
    WICTiffCompressionZIP = 6,
    WICTiffCompressionLZWHDifferencing = 7,
}
