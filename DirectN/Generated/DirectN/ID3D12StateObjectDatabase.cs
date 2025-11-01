#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c56060b7-b5fc-4135-98e0-a1e9997eace0")]
public partial interface ID3D12StateObjectDatabase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationDesc(in D3D12_APPLICATION_DESC pApplicationDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationDesc(D3D12ApplicationDescFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StorePipelineStateDesc(nint pKey, uint KeySize, uint Version, in D3D12_PIPELINE_STATE_STREAM_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindPipelineStateDesc(nint pKey, uint KeySize, D3D12PipelineStateFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoreStateObjectDesc(nint pKey, uint KeySize, uint Version, in D3D12_STATE_OBJECT_DESC pDesc, nint /* optional void* */ pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStateObjectDesc(nint pKey, uint KeySize, D3D12StateObjectFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindObjectVersion(nint pKey, uint KeySize, out uint pVersion);
}
