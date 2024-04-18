namespace DirectN;

[GeneratedComInterface, Guid("c4b1fe1b-6e84-47d5-b54c-a597981b06ad")]
public partial interface IDWriteFontFace6 : IDWriteFontFace5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFamilyNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, out IDWriteLocalizedStrings names);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFaceNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, out IDWriteLocalizedStrings names);
}
