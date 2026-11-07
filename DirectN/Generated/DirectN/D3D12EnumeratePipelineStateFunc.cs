#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL D3D12EnumeratePipelineStateFunc(nint /* in D3D12_DATABASE_GROUP_KEY */ pGroupKeys, nint /* in uint */ pVersions, uint NumGroupKeys, nint /* in D3D12_DATABASE_PIPELINE_STATE_KEY */ pPipelineStateKey, nint pContext);
