#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12StateObjectDependenciesFunc(nint /* optional D3D12_DATABASE_STATE_OBJECT_KEY* */ pParentStateObjectKey, uint NumExistingCollections, nint /* in D3D12_DATABASE_STATE_OBJECT_KEY */ pExistingCollections, nint pContext);
