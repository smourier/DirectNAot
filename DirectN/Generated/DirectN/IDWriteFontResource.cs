#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontresource
[GeneratedComInterface, Guid("1f803a76-6871-48e8-987f-b975551c50f2")]
public partial interface IDWriteFontResource
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFile>))] out IDWriteFontFile fontFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getfontfaceindex
    [PreserveSig]
    uint GetFontFaceIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getfontaxiscount
    [PreserveSig]
    uint GetFontAxisCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getdefaultfontaxisvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultFontAxisValues([In][Out][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getfontaxisranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAxisRanges([In][Out][MarshalUsing(CountElementName = nameof(fontAxisRangeCount))] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getfontaxisattributes
    [PreserveSig]
    DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes(uint axisIndex);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getaxisnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAxisNames(uint axisIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getaxisvaluenamecount
    [PreserveSig]
    uint GetAxisValueNameCount(uint axisIndex);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-getaxisvaluenames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAxisValueNames(uint axisIndex, uint axisValueIndex, out DWRITE_FONT_AXIS_RANGE fontAxisRange, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-hasvariations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool HasVariations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace5>))] out IDWriteFontFace5 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontresource-createfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference1>))] out IDWriteFontFaceReference1 fontFaceReference);
}
