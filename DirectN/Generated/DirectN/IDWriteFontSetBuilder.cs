#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontsetbuilder
[GeneratedComInterface, Guid("2f642afe-9c68-4f40-b8be-457401afcb3d")]
public partial interface IDWriteFontSetBuilder
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder-addfontfacereference(idwritefontfacereference)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontFaceReference(IDWriteFontFaceReference fontFaceReference, [In][MarshalUsing(CountElementName = nameof(propertyCount))] DWRITE_FONT_PROPERTY[] properties, uint propertyCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder-addfontfacereference(idwritefontfacereference)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontFaceReference(IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder-addfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontSet(IDWriteFontSet fontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontsetbuilder-createfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontSet([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet>))] out IDWriteFontSet fontSet);
}
