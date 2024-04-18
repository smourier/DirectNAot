namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatareaderinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("eebf1f5b-07c1-4447-a3ab-22acaf78a804")]
public partial interface IWICMetadataReaderInfo : IWICMetadataHandlerInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareaderinfo-getpatterns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPatterns(in Guid guidContainerFormat, uint cbSize, nint/* nint */ pPattern, nint/* nint */ pcCount, nint/* nint */ pcbActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareaderinfo-matchespattern
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MatchesPattern(in Guid guidContainerFormat, IStream pIStream, [MarshalAs(UnmanagedType.U4)] out bool pfMatches);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareaderinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInstance(out IWICMetadataReader ppIReader);
}
