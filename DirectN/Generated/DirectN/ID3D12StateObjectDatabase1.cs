#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c700e43f-47a6-4ec6-ad83-f275400231af")]
public partial interface ID3D12StateObjectDatabase1 : ID3D12StateObjectDatabase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumeratePipelineStates(D3D12EnumeratePipelineStateFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateStateObjects(D3D12EnumerateStateObjectFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStateObjectDependencies(nint /* optional D3D12_DATABASE_GROUP_KEY* */ pGroupKey, nint /* optional D3D12_DATABASE_STATE_OBJECT_KEY* */ pStateObjectKey, D3D12StateObjectDependenciesFunc CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationDesc1(in D3D12_APPLICATION_DESC pApplicationDesc, in Guid AppId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationDesc1(D3D12ApplicationDescFunc1 CallbackFunc, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindPipelineStateDesc1(nint /* optional D3D12_DATABASE_GROUP_KEY* */ pGroupKey, nint /* optional D3D12_DATABASE_PIPELINE_STATE_KEY* */ pPipelineStateKey, D3D12_FIND_PIPELINE_STATE_DESC_FLAGS Flags, D3D12PipelineStateFunc1 CallbackFunc, D3D12CreateRootSignatureFunc? pfnCreateRootSignature, D3D12LookupRootSignatureFunc? pfnLookupRootSignature, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStateObjectDesc1(nint /* optional D3D12_DATABASE_GROUP_KEY* */ pGroupKey, nint /* optional D3D12_DATABASE_STATE_OBJECT_KEY* */ pStateObjectKey, D3D12_FIND_STATE_OBJECT_DESC_FLAGS Flags, D3D12StateObjectFunc1 CallbackFunc, D3D12LookupStateObjectFunc? pfnLookupStateObject, D3D12CreateRootSignatureFunc? pfnCreateRootSignature, D3D12LookupRootSignatureFunc? pfnLookupRootSignature, nint /* optional void* */ pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPipelineStateDescCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStateObjectDescCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginTransaction(D3D12_TRANSACTION_TYPE Type);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitTransaction();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RollbackTransaction();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsTransactionActive();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Checkpoint(D3D12_CHECKPOINT_MODE CheckpointMode, D3D12_JOURNAL_MODE JournalMode, nint /* optional D3D12_JOURNAL_MODE* */ pPreviousJournalMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StorePipelineStateDesc1(nint /* optional D3D12_DATABASE_GROUP_KEY* */ pGroupKeys, nint /* optional uint* */ pVersions, uint NumGroupKeys, in D3D12_PIPELINE_STATE_STREAM_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoreStateObjectDesc1(nint /* optional D3D12_DATABASE_GROUP_KEY* */ pGroupKeys, nint /* optional uint* */ pVersions, uint NumGroupKeys, in D3D12_STATE_OBJECT_DESC pDesc, nint /* optional D3D12_DATABASE_GROUP_KEY* */ pStateObjectToGrowFromGroupKey, nint pCreatedObject, nint pStateObjectToGrowFrom);
}
