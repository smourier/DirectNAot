#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("61f307d3-d34e-4e7c-8374-3ba4de23cccb")]
public partial interface ID3D12DeviceFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromGlobalState();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyToGlobalState();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(D3D12_DEVICE_FACTORY_FLAGS flags);
    
    [PreserveSig]
    D3D12_DEVICE_FACTORY_FLAGS GetFlags();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConfigurationInterface(in Guid clsid, in Guid iid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableExperimentalFeatures(uint NumFeatures, [In][MarshalUsing(CountElementName = nameof(NumFeatures))] Guid[] pIIDs, nint /* optional void* */ pConfigurationStructs, nint /* optional uint* */ pConfigurationStructSizes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(nint adapter, D3D_FEATURE_LEVEL FeatureLevel, in Guid riid, out nint /* void */ ppvDevice);
}
