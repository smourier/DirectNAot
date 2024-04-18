namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_SERIALIZE_VERSIONED_ROOT_SIGNATURE(nint /* in D3D12_VERSIONED_ROOT_SIGNATURE_DESC */ pRootSignature, nint ppBlob, nint ppErrorBlob);
