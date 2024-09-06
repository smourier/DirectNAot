#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicenummetadataitem
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("dc2bb46d-3f07-481e-8625-220c4aedbb33")]
public partial interface IWICEnumMetadataItem
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicenummetadataitem-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] PROPVARIANT[] rgeltSchema, [In][Out][MarshalUsing(CountElementName = nameof(celt))] PROPVARIANT[] rgeltId, [In][Out][MarshalUsing(CountElementName = nameof(celt))] PROPVARIANT[] rgeltValue, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicenummetadataitem-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicenummetadataitem-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicenummetadataitem-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICEnumMetadataItem>))] out IWICEnumMetadataItem ppIEnumMetadataItem);
}
