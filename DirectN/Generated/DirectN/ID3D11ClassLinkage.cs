#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11classlinkage
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed")]
public partial interface ID3D11ClassLinkage : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11classlinkage-getclassinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClassInstance(PSTR pClassInstanceName, uint InstanceIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11ClassInstance>))] out ID3D11ClassInstance ppInstance);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11classlinkage-createclassinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateClassInstance(PSTR pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11ClassInstance>))] out ID3D11ClassInstance ppInstance);
}
