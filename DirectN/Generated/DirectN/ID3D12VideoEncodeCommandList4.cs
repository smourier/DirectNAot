#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("69aeb5b7-55f2-4012-8b73-3a88d65a204c")]
public partial interface ID3D12VideoEncodeCommandList4 : ID3D12VideoEncodeCommandList3
{
    [PreserveSig]
    void EncodeFrame1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12VideoEncoder>))] ID3D12VideoEncoder pEncoder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12VideoEncoderHeap1>))] ID3D12VideoEncoderHeap1 pHeap, in D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1 pInputArguments, in D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1 pOutputArguments);
    
    [PreserveSig]
    void ResolveEncoderOutputMetadata1(in D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1 pInputArguments, in D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_ARGUMENTS1 pOutputArguments);
    
    [PreserveSig]
    void ResolveInputParamLayout(in D3D12_VIDEO_ENCODER_RESOLVE_INPUT_PARAM_LAYOUT_INPUT_ARGUMENTS pInputArguments, in D3D12_VIDEO_ENCODER_RESOLVE_INPUT_PARAM_LAYOUT_OUTPUT_ARGUMENTS pOutputArguments);
}
