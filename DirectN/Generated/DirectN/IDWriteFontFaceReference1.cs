#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontfacereference1
[GeneratedComInterface, Guid("c081fe77-2fd1-41ac-a5a3-34983c4ba61a")]
public partial interface IDWriteFontFaceReference1 : IDWriteFontFaceReference
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference1-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace5>))] out IDWriteFontFace5 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference1-getfontaxisvaluecount
    [PreserveSig]
    uint GetFontAxisValueCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference1-getfontaxisvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAxisValues([In][Out][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount);
}
