namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontset3
[GeneratedComInterface, Guid("7c073ef2-a7f4-4045-8c32-8ab8ae640f90")]
public partial interface IDWriteFontSet3 : IDWriteFontSet2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset3-getfontsourcetype
    [PreserveSig]
    DWRITE_FONT_SOURCE_TYPE GetFontSourceType(uint fontIndex);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset3-getfontsourcenamelength
    [PreserveSig]
    uint GetFontSourceNameLength(uint listIndex);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset3-getfontsourcename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontSourceName(uint listIndex, out PWSTR stringBuffer, uint stringBufferSize);
}
