namespace DirectN;

[GeneratedComInterface, Guid("bfbfb953-644f-4792-b69c-dfaca4cbf89a")]
public partial interface IXFeedEnclosure
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Url(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Type(out PWSTR ppszMimeType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Length(out uint puiLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AsyncDownload();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelAsyncDownload();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadStatus(out FEEDS_DOWNLOAD_STATUS pfds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastDownloadError(out FEEDS_DOWNLOAD_ERROR pfde);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LocalPath(out PWSTR ppszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Parent(in Guid riid, out nint ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadUrl(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadMimeType(out PWSTR ppszMimeType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFile();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFile(PWSTR pszDownloadUrl, PWSTR pszDownloadFilePath, PWSTR pszDownloadMimeType, PWSTR pszEnclosureFilename);
}
