﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontface
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5f49804d-7024-4d43-bfa9-d25984f53849")]
public partial interface IDWriteFontFace
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-gettype
    [PreserveSig]
    DWRITE_FONT_FACE_TYPE GetType();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getfiles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFiles(ref uint numberOfFiles, nint /* optional IDWriteFontFile* */ fontFiles);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getindex
    [PreserveSig]
    uint GetIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getsimulations
    [PreserveSig]
    DWRITE_FONT_SIMULATIONS GetSimulations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-issymbolfont
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsSymbolFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getmetrics
    [PreserveSig]
    void GetMetrics(out DWRITE_FONT_METRICS fontFaceMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getglyphcount
    [PreserveSig]
    ushort GetGlyphCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getdesignglyphmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesignGlyphMetrics([In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, uint glyphCount, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_METRICS[] glyphMetrics, BOOL isSideways);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getglyphindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphIndices([In][MarshalUsing(CountElementName = nameof(codePointCount))] uint[] codePoints, uint codePointCount, [In][Out][MarshalUsing(CountElementName = nameof(codePointCount))] ushort[] glyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-trygetfonttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryGetFontTable(uint openTypeTableTag, out nint tableData, out uint tableSize, out nint tableContext, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-releasefonttable
    [PreserveSig]
    void ReleaseFontTable(nint tableContext);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getglyphrunoutline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphRunOutline(float emSize, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, nint /* optional float* */ glyphAdvances, nint /* optional DWRITE_GLYPH_OFFSET* */ glyphOffsets, uint glyphCount, BOOL isSideways, BOOL isRightToLeft, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SimplifiedGeometrySink>))] ID2D1SimplifiedGeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getrecommendedrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteRenderingParams>))] IDWriteRenderingParams renderingParams, out DWRITE_RENDERING_MODE renderingMode);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontface-getgdicompatiblemetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, out DWRITE_FONT_METRICS fontFaceMetrics);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontface-getgdicompatibleglyphmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, BOOL useGdiNatural, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, uint glyphCount, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_METRICS[] glyphMetrics, BOOL isSideways);
}
