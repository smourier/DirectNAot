namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatawriterinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b22e3fba-3925-4323-b5c1-9ebfc430f236")]
public partial interface IWICMetadataWriterInfo : IWICMetadataHandlerInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriterinfo-getheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHeader(in Guid guidContainerFormat, uint cbSize, nint/* nint */ pHeader, nint/* nint */ pcbActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriterinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInstance(out IWICMetadataWriter ppIWriter);
}
