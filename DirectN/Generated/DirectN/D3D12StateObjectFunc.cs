#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12StateObjectFunc(nint pKey, uint KeySize, uint Version, nint /* in D3D12_STATE_OBJECT_DESC */ pDesc, nint pParentKey, uint ParentKeySize, nint pContext);
