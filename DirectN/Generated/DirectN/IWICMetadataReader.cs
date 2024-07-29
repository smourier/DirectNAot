#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatareader
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9204fe99-d8fc-4fd5-a001-9536b067a899")]
public partial interface IWICMetadataReader
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareader-getmetadataformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataFormat(out Guid pguidMetadataFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareader-getmetadatahandlerinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataHandlerInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataHandlerInfo>))] out IWICMetadataHandlerInfo ppIHandler);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareader-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareader-getvaluebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueByIndex(uint nIndex, ref PROPVARIANT pvarSchema, ref PROPVARIANT pvarId, ref PROPVARIANT pvarValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareader-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(in PROPVARIANT pvarSchema, in PROPVARIANT pvarId, ref PROPVARIANT pvarValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatareader-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICEnumMetadataItem>))] out IWICEnumMetadataItem ppIEnumMetadata);
}
