namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist2
[GeneratedComInterface, Guid("38c3e585-ff17-412c-9150-4fc6f9d72a28")]
public partial interface ID3D12GraphicsCommandList2 : ID3D12GraphicsCommandList1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist2-writebufferimmediate
    [PreserveSig]
    public void WriteBufferImmediate(uint Count, in D3D12_WRITEBUFFERIMMEDIATE_PARAMETER pParams, nint/* nint */ pModes);
}
