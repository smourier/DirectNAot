namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/nn-d3dcsx-id3dx11segmentedscan
[GeneratedComInterface, Guid("a915128c-d954-4c79-bfe1-64db923194d6")]
public partial interface ID3DX11SegmentedScan
{
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11segmentedscan-setscandirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScanDirection(D3DX11_SCAN_DIRECTION Direction);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11segmentedscan-segscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SegScan(D3DX11_SCAN_DATA_TYPE ElementType, D3DX11_SCAN_OPCODE OpCode, uint ElementScanSize, ID3D11UnorderedAccessView? pSrc, ID3D11UnorderedAccessView pSrcElementFlags, ID3D11UnorderedAccessView pDst);
}
