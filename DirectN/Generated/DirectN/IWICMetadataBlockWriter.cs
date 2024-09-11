#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatablockwriter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("08fb9676-b444-41e8-8dbe-6a53a542bff1")]
public partial interface IWICMetadataBlockWriter : IWICMetadataBlockReader
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockwriter-initializefromblockreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromBlockReader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataBlockReader>))] IWICMetadataBlockReader pIMDBlockReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockwriter-getwriterbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWriterByIndex(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataWriter>))] out IWICMetadataWriter ppIMetadataWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockwriter-addwriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddWriter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataWriter>))] IWICMetadataWriter pIMetadataWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockwriter-setwriterbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWriterByIndex(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataWriter>))] IWICMetadataWriter pIMetadataWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatablockwriter-removewriterbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveWriterByIndex(uint nIndex);
}
