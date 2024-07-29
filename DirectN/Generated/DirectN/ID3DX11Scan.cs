#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/nn-d3dcsx-id3dx11scan
[GeneratedComInterface, Guid("5089b68f-e71d-4d38-be8e-f363b95a9405")]
public partial interface ID3DX11Scan
{
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11scan-setscandirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScanDirection(D3DX11_SCAN_DIRECTION Direction);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11scan-scan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Scan(D3DX11_SCAN_DATA_TYPE ElementType, D3DX11_SCAN_OPCODE OpCode, uint ElementScanSize, ID3D11UnorderedAccessView pSrc, ID3D11UnorderedAccessView pDst);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11scan-multiscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Multiscan(D3DX11_SCAN_DATA_TYPE ElementType, D3DX11_SCAN_OPCODE OpCode, uint ElementScanSize, uint ElementScanPitch, uint ScanCount, ID3D11UnorderedAccessView pSrc, ID3D11UnorderedAccessView pDst);
}
