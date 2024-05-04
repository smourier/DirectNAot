#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontdownloadqueue
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("b71e6052-5aea-4fa3-832e-f60d431f7e91")]
public partial interface IDWriteFontDownloadQueue
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadqueue-addlistener
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddListener(IDWriteFontDownloadListener listener, out uint token);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadqueue-removelistener
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveListener(uint token);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadqueue-isempty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsEmpty();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadqueue-begindownload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginDownload(nint context);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadqueue-canceldownload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelDownload();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadqueue-getgenerationcount
    [PreserveSig]
    ulong GetGenerationCount();
}
