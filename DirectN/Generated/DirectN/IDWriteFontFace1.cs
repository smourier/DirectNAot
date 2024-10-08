﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritefontface1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a71efdb4-9fdb-4838-ad90-cfc3be8c3daf")]
public partial interface IDWriteFontFace1 : IDWriteFontFace
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getmetrics
    [PreserveSig]
    void GetMetrics(out DWRITE_FONT_METRICS1 fontMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getgdicompatiblemetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, out DWRITE_FONT_METRICS1 fontMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getcaretmetrics
    [PreserveSig]
    void GetCaretMetrics(out DWRITE_CARET_METRICS caretMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getunicoderanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnicodeRanges(uint maxRangeCount, nint /* optional DWRITE_UNICODE_RANGE* */ unicodeRanges, out uint actualRangeCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-ismonospacedfont
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsMonospacedFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getdesignglyphadvances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesignGlyphAdvances(uint glyphCount, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] int[] glyphAdvances, BOOL isSideways);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getgdicompatibleglyphadvances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, BOOL useGdiNatural, BOOL isSideways, uint glyphCount, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] int[] glyphAdvances);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getkerningpairadjustments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKerningPairAdjustments(uint glyphCount, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] int[] glyphAdvanceAdjustments);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-haskerningpairs
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL HasKerningPairs();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getrecommendedrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, nint /* optional DWRITE_MATRIX* */ transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, out DWRITE_RENDERING_MODE renderingMode);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-getverticalglyphvariants
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVerticalGlyphVariants(uint glyphCount, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] nominalGlyphIndices, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] verticalGlyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefontface1-hasverticalglyphvariants
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL HasVerticalGlyphVariants();
}
