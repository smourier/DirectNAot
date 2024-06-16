#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontset1
[GeneratedComInterface, Guid("7e9fda85-6c92-4053-bc47-7ae3530db4d3")]
public partial interface IDWriteFontSet1 : IDWriteFontSet
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getmatchingfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts(nint /* optional DWRITE_FONT_PROPERTY* */ fontProperty, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 matchingFonts);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfirstfontresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFirstFontResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 filteredFontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfilteredfonts(uint32const_uint32_idwritefontset1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteredFonts([In][MarshalUsing(CountElementName = nameof(indexCount))] uint[] indices, uint indexCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 filteredFontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfilteredfonts(uint32const_uint32_idwritefontset1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteredFonts([In][MarshalUsing(CountElementName = nameof(fontAxisRangeCount))] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount, BOOL selectAnyRange, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 filteredFontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfilteredfonts(uint32const_uint32_idwritefontset1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteredFonts(nint /* optional DWRITE_FONT_PROPERTY* */ properties, uint propertyCount, BOOL selectAnyProperty, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 filteredFontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfilteredfontindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteredFontIndices([In][MarshalUsing(CountElementName = nameof(fontAxisRangeCount))] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount, BOOL selectAnyRange, [In][Out][MarshalUsing(CountElementName = nameof(maxIndexCount))] uint[] indices, uint maxIndexCount, out uint actualIndexCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfilteredfontindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteredFontIndices([In][MarshalUsing(CountElementName = nameof(propertyCount))] DWRITE_FONT_PROPERTY[] properties, uint propertyCount, BOOL selectAnyProperty, [In][Out][MarshalUsing(CountElementName = nameof(maxIndexCount))] uint[] indices, uint maxIndexCount, out uint actualIndexCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfontaxisranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAxisRanges(uint listIndex, [In][Out][MarshalUsing(CountElementName = nameof(maxFontAxisRangeCount))] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint maxFontAxisRangeCount, out uint actualFontAxisRangeCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfontaxisranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAxisRanges([In][Out][MarshalUsing(CountElementName = nameof(maxFontAxisRangeCount))] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint maxFontAxisRangeCount, out uint actualFontAxisRangeCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFaceReference(uint listIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference1>))] out IDWriteFontFaceReference1 fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-createfontresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontResource(uint listIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontResource>))] out IDWriteFontResource fontResource);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace(uint listIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace5>))] out IDWriteFontFace5 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset1-getfontlocality
    [PreserveSig]
    DWRITE_LOCALITY GetFontLocality(uint listIndex);
}
