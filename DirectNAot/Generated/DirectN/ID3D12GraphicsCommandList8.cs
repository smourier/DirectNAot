#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ee936ef9-599d-4d28-938e-23c4ad05ce51")]
public partial interface ID3D12GraphicsCommandList8 : ID3D12GraphicsCommandList7
{
    [PreserveSig]
    void OMSetFrontAndBackStencilRef(uint FrontStencilRef, uint BackStencilRef);
}
