#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e59ad09e-f1ae-42bb-8983-9f6e5586c4eb")]
public partial interface ID3D12VideoDevice4 : ID3D12VideoDevice3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoEncoderHeap1(in D3D12_VIDEO_ENCODER_HEAP_DESC1 pDesc, in Guid riid, out nint /* void */ ppVideoEncoderHeap);
}
