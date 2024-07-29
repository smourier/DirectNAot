#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c4b1fe1b-6e84-47d5-b54c-a597981b06ad")]
public partial interface IDWriteFontFace6 : IDWriteFontFace5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFamilyNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFaceNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
}
