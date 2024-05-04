#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomglyphseditor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a5ab8616-5b16-4b9f-9629-89b323ed7909")]
public partial interface IXpsOMGlyphsEditor
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-applyedits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyEdits();
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getunicodestring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnicodeString(out PWSTR unicodeString);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setunicodestring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnicodeString(PWSTR unicodeString);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getglyphindexcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphIndexCount(out uint indexCount);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getglyphindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphIndices(ref uint indexCount, out XPS_GLYPH_INDEX glyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setglyphindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGlyphIndices(uint indexCount, in XPS_GLYPH_INDEX glyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getglyphmappingcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphMappingCount(out uint glyphMappingCount);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getglyphmappings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphMappings(ref uint glyphMappingCount, out XPS_GLYPH_MAPPING glyphMappings);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setglyphmappings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGlyphMappings(uint glyphMappingCount, in XPS_GLYPH_MAPPING glyphMappings);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getprohibitedcaretstopcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProhibitedCaretStopCount(out uint prohibitedCaretStopCount);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getprohibitedcaretstops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProhibitedCaretStops(ref uint count, out uint prohibitedCaretStops);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setprohibitedcaretstops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProhibitedCaretStops(uint count, in uint prohibitedCaretStops);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getbidilevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBidiLevel(out uint bidiLevel);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setbidilevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBidiLevel(uint bidiLevel);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getissideways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsSideways([MarshalAs(UnmanagedType.U4)] out bool isSideways);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setissideways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsSideways([MarshalAs(UnmanagedType.U4)] bool isSideways);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-getdevicefontname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceFontName(out PWSTR deviceFontName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomglyphseditor-setdevicefontname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeviceFontName(PWSTR deviceFontName);
}
