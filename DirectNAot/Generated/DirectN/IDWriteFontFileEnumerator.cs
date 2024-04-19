namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfileenumerator
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("72755049-5ff7-435d-8348-4be97cfa6c7c")]
public partial interface IDWriteFontFileEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfileenumerator-movenext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext([MarshalAs(UnmanagedType.U4)] out bool hasCurrentFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfileenumerator-getcurrentfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentFontFile(out IDWriteFontFile fontFile);
}
