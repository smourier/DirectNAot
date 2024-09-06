#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("78dbf87b-f766-422b-a61c-c8c446bdb9ad")]
public partial interface ID3D12DeviceConfiguration
{
    [PreserveSig]
    D3D12_DEVICE_CONFIGURATION_DESC GetDesc();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnabledExperimentalFeatures([In][Out][MarshalUsing(CountElementName = nameof(NumGuids))] Guid[] pGuids, uint NumGuids);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SerializeVersionedRootSignature(in D3D12_VERSIONED_ROOT_SIGNATURE_DESC pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppResult, nint /* optional ID3DBlob* */ ppError);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVersionedRootSignatureDeserializer(nint pBlob, nuint Size, in Guid riid, out nint /* void */ ppvDeserializer);
}
