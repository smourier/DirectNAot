#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_SERIALIZE_ROOT_SIGNATURE(nint /* in D3D12_ROOT_SIGNATURE_DESC */ pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, nint ppBlob, nint ppErrorBlob);
