namespace DirectN;

[GeneratedComInterface, Guid("5405c344-d457-444e-b4dd-2366e45aee39")]
public partial interface ID3D12Device11 : ID3D12Device10
{
    [PreserveSig]
    void CreateSampler2(in D3D12_SAMPLER_DESC2 pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
}
