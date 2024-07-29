#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritefont1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("acd16696-8c14-4f5d-877e-fe3fc1d32738")]
public partial interface IDWriteFont1 : IDWriteFont
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefont1-getmetrics
    [PreserveSig]
    void GetMetrics(out DWRITE_FONT_METRICS1 fontMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefont1-getpanose
    [PreserveSig]
    void GetPanose(out DWRITE_PANOSE panose);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefont1-getunicoderanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnicodeRanges(uint maxRangeCount, nint /* optional DWRITE_UNICODE_RANGE* */ unicodeRanges, out uint actualRangeCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefont1-ismonospacedfont
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsMonospacedFont();
}
