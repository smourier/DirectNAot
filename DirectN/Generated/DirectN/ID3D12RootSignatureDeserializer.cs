#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12rootsignaturedeserializer
[GeneratedComInterface, Guid("34ab647b-3cc8-46ac-841b-c0965645c046")]
public partial interface ID3D12RootSignatureDeserializer
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12rootsignaturedeserializer-getrootsignaturedesc
    [PreserveSig]
    nint GetRootSignatureDesc();
}
