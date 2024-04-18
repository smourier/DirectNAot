namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontface
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5f49804d-7024-4d43-bfa9-d25984f53849")]
public partial interface IDWriteFontFace
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-gettype
    [PreserveSig]
    public DWRITE_FONT_FACE_TYPE GetType();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getfiles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFiles(ref uint numberOfFiles, nint /* IDWriteFontFile */ fontFiles);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getindex
    [PreserveSig]
    public uint GetIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getsimulations
    [PreserveSig]
    public DWRITE_FONT_SIMULATIONS GetSimulations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-issymbolfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsSymbolFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getmetrics
    [PreserveSig]
    public void GetMetrics(out DWRITE_FONT_METRICS fontFaceMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getglyphcount
    [PreserveSig]
    public ushort GetGlyphCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getdesignglyphmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesignGlyphMetrics(in ushort glyphIndices, uint glyphCount, out DWRITE_GLYPH_METRICS glyphMetrics, [MarshalAs(UnmanagedType.U4)] bool isSideways);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getglyphindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGlyphIndices(in uint codePoints, uint codePointCount, out ushort glyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-trygetfonttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT TryGetFontTable(uint openTypeTableTag, out nint tableData, out uint tableSize, out nint tableContext, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-releasefonttable
    [PreserveSig]
    public void ReleaseFontTable(nint tableContext);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getglyphrunoutline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGlyphRunOutline(float emSize, in ushort glyphIndices, nint /* float */ glyphAdvances, nint /* DWRITE_GLYPH_OFFSET */ glyphOffsets, uint glyphCount, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, ID2D1SimplifiedGeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontface-getrecommendedrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams renderingParams, out DWRITE_RENDERING_MODE renderingMode);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontface-getgdicompatiblemetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, nint /* DWRITE_MATRIX */ transform, out DWRITE_FONT_METRICS fontFaceMetrics);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontface-getgdicompatibleglyphmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, nint /* DWRITE_MATRIX */ transform, [MarshalAs(UnmanagedType.U4)] bool useGdiNatural, in ushort glyphIndices, uint glyphCount, out DWRITE_GLYPH_METRICS glyphMetrics, [MarshalAs(UnmanagedType.U4)] bool isSideways);
}
