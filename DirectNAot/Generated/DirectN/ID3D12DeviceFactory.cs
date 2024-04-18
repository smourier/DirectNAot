namespace DirectN;

[GeneratedComInterface, Guid("61f307d3-d34e-4e7c-8374-3ba4de23cccb")]
public partial interface ID3D12DeviceFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InitializeFromGlobalState();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ApplyToGlobalState();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFlags(D3D12_DEVICE_FACTORY_FLAGS flags);
    
    [PreserveSig]
    public D3D12_DEVICE_FACTORY_FLAGS GetFlags();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetConfigurationInterface(in Guid clsid, in Guid iid, out nint ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnableExperimentalFeatures(uint NumFeatures, in Guid pIIDs, nint/* nint */ pConfigurationStructs, nint/* nint */ pConfigurationStructSizes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDevice(nint adapter, D3D_FEATURE_LEVEL FeatureLevel, in Guid riid, nint/* nint */ ppvDevice);
}
