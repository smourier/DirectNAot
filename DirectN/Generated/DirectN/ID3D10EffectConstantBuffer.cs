#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectconstantbuffer
[GeneratedComInterface, Guid("56648f4d-cc8b-4444-a5ad-b5a3d76e91b3")]
public partial interface ID3D10EffectConstantBuffer : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-setconstantbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConstantBuffer(ID3D10Buffer? pConstantBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-getconstantbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConstantBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Buffer>))] out ID3D10Buffer ppConstantBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-settexturebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextureBuffer(ID3D10ShaderResourceView? pTextureBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-gettexturebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextureBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10ShaderResourceView>))] out ID3D10ShaderResourceView ppTextureBuffer);
}
