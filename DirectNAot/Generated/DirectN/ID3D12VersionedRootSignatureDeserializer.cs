namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12versionedrootsignaturedeserializer
[GeneratedComInterface, Guid("7f91ce67-090c-4bb7-b78e-ed8ff2e31da0")]
public partial interface ID3D12VersionedRootSignatureDeserializer
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12versionedrootsignaturedeserializer-getrootsignaturedescatversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, out nint ppDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12versionedrootsignaturedeserializer-getunconvertedrootsignaturedesc
    [PreserveSig]
    D3D12_VERSIONED_ROOT_SIGNATURE_DESC GetUnconvertedRootSignatureDesc();
}
