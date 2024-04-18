namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontlist
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1a0d8438-1d97-4ec1-aef9-a2fb86ed6acb")]
public partial interface IDWriteFontList
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontlist-getfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontCollection(out IDWriteFontCollection fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontlist-getfontcount
    [PreserveSig]
    public uint GetFontCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontlist-getfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFont(uint index, out IDWriteFont font);
}
