#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12PipelineStateFunc(nint pKey, uint KeySize, uint Version, nint /* in D3D12_PIPELINE_STATE_STREAM_DESC */ pDesc, nint pContext);
