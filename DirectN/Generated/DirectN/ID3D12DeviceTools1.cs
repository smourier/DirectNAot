#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e30e9fc7-e641-4d6e-8a81-9dd9206ec47a")]
public partial interface ID3D12DeviceTools1 : ID3D12DeviceTools
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationSpecificDriverState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppBlob);
    
    [PreserveSig]
    D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS GetApplicationSpecificDriverBlobStatus();
}
