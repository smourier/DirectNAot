#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12StateObjectFunc1(nint /* in D3D12_DATABASE_GROUP_KEY */ pGroupKeys, nint /* in uint */ pVersions, uint NumGroupKeys, nint /* in D3D12_DATABASE_STATE_OBJECT_KEY */ pStateObjectKey, nint /* optional D3D12_STATE_OBJECT_DESC* */ pDesc, nint /* optional D3D12_DATABASE_STATE_OBJECT_KEY* */ pParentKey, nint /* optional D3D12_DATABASE_GROUP_KEY* */ pParentGroupKey, nint pContext);
