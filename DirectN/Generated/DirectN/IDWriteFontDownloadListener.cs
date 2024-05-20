#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontdownloadlistener
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("b06fe5b9-43ec-4393-881b-dbe4dc72fda7")]
public partial interface IDWriteFontDownloadListener
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontdownloadlistener-downloadcompleted
    [PreserveSig]
    void DownloadCompleted(IDWriteFontDownloadQueue downloadQueue, nint context, HRESULT downloadResult);
}
