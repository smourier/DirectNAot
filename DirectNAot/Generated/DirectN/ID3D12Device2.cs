namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device2
[GeneratedComInterface, Guid("30baa41e-b15b-475c-a0bb-1af5c5b64328")]
public partial interface ID3D12Device2 : ID3D12Device1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device2-createpipelinestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePipelineState(in D3D12_PIPELINE_STATE_STREAM_DESC pDesc, in Guid riid, out nint ppPipelineState);
}
