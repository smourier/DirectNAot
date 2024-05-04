#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatawriterinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b22e3fba-3925-4323-b5c1-9ebfc430f236")]
public partial interface IWICMetadataWriterInfo : IWICMetadataHandlerInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriterinfo-getheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeader(in Guid guidContainerFormat, uint cbSize, nint /* optional WICMetadataHeader* */ pHeader, nint /* optional uint* */ pcbActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriterinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(out IWICMetadataWriter ppIWriter);
}
