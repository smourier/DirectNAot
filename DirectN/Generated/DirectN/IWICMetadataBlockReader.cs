#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatablockreader
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("feaa2a8d-b3f3-43e4-b25c-d1de990a1ae1")]
public partial interface IWICMetadataBlockReader
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockreader-getcontainerformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerFormat(out Guid pguidContainerFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockreader-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockreader-getreaderbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReaderByIndex(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataReader>))] out IWICMetadataReader ppIMetadataReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockreader-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumUnknown>))] out IEnumUnknown ppIEnumMetadata);
}
