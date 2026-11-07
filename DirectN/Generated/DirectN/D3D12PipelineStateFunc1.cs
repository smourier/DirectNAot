#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12PipelineStateFunc1(nint /* in D3D12_DATABASE_GROUP_KEY */ pGroupKeys, nint /* in uint */ pVersions, uint NumGroupKeys, nint /* in D3D12_DATABASE_PIPELINE_STATE_KEY */ pPipelineStateKey, nint /* optional D3D12_PIPELINE_STATE_STREAM_DESC* */ pDesc, nint pContext);
