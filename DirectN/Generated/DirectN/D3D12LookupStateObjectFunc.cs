#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT D3D12LookupStateObjectFunc(nint /* in D3D12_DATABASE_STATE_OBJECT_KEY */ pStateObjectKey, nint /* in D3D12_DATABASE_GROUP_KEY */ pGroupKey, nint ppStateObject, nint pContext);
