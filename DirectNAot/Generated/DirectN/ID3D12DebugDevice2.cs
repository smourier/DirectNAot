namespace DirectN;

[GeneratedComInterface, Guid("60eccbc1-378d-4df1-894c-f8ac5ce4d7dd")]
public partial interface ID3D12DebugDevice2 : ID3D12DebugDevice
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, nint pData, uint DataSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, nint pData, uint DataSize);
}
