namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_CREATE_ROOT_SIGNATURE_DESERIALIZER(nint pSrcData, nuint SrcDataSizeInBytes, nint /* in Guid */ pRootSignatureDeserializerInterface, nint ppRootSignatureDeserializer);
