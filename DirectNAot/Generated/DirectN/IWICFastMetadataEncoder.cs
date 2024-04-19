namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicfastmetadataencoder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b84e2c09-78c9-4ac4-8bd3-524ae1663a2f")]
public partial interface IWICFastMetadataEncoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicfastmetadataencoder-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicfastmetadataencoder-getmetadataquerywriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataQueryWriter(out IWICMetadataQueryWriter ppIMetadataQueryWriter);
}
