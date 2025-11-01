#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5646804c-9638-48f7-9182-b3ee5a6b60fb")]
public partial interface ID3D12PipelineState1 : ID3D12PipelineState
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRootSignature(in Guid riid, out nint /* void */ ppvRootSignature);
}
