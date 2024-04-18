namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefont3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944")]
public partial interface IDWriteFont3 : IDWriteFont2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateFontFace(out IDWriteFontFace3 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-equals
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool Equals(IDWriteFont font);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-getfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFaceReference(out IDWriteFontFaceReference fontFaceReference);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool HasCharacter(uint unicodeValue);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-getlocality
    [PreserveSig]
    public DWRITE_LOCALITY GetLocality();
}
