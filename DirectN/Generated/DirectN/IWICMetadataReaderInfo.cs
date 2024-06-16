#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatareaderinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("eebf1f5b-07c1-4447-a3ab-22acaf78a804")]
public partial interface IWICMetadataReaderInfo : IWICMetadataHandlerInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareaderinfo-getpatterns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPatterns(in Guid guidContainerFormat, uint cbSize, nint /* optional WICMetadataPattern* */ pPattern, nint /* optional uint* */ pcCount, nint /* optional uint* */ pcbActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareaderinfo-matchespattern
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MatchesPattern(in Guid guidContainerFormat, IStream pIStream, out BOOL pfMatches);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareaderinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataReader>))] out IWICMetadataReader ppIReader);
}
