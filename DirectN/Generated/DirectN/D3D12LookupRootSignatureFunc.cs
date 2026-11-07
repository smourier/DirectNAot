#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT D3D12LookupRootSignatureFunc(nint /* in D3D12_DATABASE_ROOT_SIGNATURE_KEY */ pRootSignatureKey, nint ppRootSignature, nint pContext);
