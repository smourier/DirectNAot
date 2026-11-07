#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL D3D12EnumerateStateObjectFunc(nint /* in D3D12_DATABASE_GROUP_KEY */ pGroupKeys, nint /* in uint */ pVersions, uint NumGroupKeys, nint /* in D3D12_DATABASE_STATE_OBJECT_KEY */ pStateObjectKey, nint pContext);
