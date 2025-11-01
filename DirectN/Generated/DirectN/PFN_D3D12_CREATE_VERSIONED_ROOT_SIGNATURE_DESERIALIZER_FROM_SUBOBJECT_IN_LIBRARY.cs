#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_CREATE_VERSIONED_ROOT_SIGNATURE_DESERIALIZER_FROM_SUBOBJECT_IN_LIBRARY(nint pSrcData, nuint SrcDataSizeInBytes, PWSTR RootSignatureSubobjectName, nint /* in Guid */ pRootSignatureDeserializerInterface, nint ppRootSignatureDeserializer);
