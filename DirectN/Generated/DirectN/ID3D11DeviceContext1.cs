#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11devicecontext1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1")]
public partial interface ID3D11DeviceContext1 : ID3D11DeviceContext
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-copysubresourceregion1
    [PreserveSig]
    void CopySubresourceRegion1(ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource pSrcResource, uint SrcSubresource, nint /* optional D3D11_BOX* */ pSrcBox, uint CopyFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-updatesubresource1
    [PreserveSig]
    void UpdateSubresource1(ID3D11Resource pDstResource, uint DstSubresource, nint /* optional D3D11_BOX* */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardresource
    [PreserveSig]
    void DiscardResource(ID3D11Resource pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardview
    [PreserveSig]
    void DiscardView(ID3D11View pResourceView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-vssetconstantbuffers1
    [PreserveSig]
    void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-hssetconstantbuffers1
    [PreserveSig]
    void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-dssetconstantbuffers1
    [PreserveSig]
    void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-gssetconstantbuffers1
    [PreserveSig]
    void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-pssetconstantbuffers1
    [PreserveSig]
    void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-cssetconstantbuffers1
    [PreserveSig]
    void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-vsgetconstantbuffers1
    [PreserveSig]
    void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-hsgetconstantbuffers1
    [PreserveSig]
    void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-dsgetconstantbuffers1
    [PreserveSig]
    void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-gsgetconstantbuffers1
    [PreserveSig]
    void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-psgetconstantbuffers1
    [PreserveSig]
    void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-csgetconstantbuffers1
    [PreserveSig]
    void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint /* optional ID3D11Buffer* */ ppConstantBuffers, nint /* optional uint* */ pFirstConstant, nint /* optional uint* */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-swapdevicecontextstate
    [PreserveSig]
    void SwapDeviceContextState(ID3DDeviceContextState pState, nint /* optional ID3DDeviceContextState* */ ppPreviousState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-clearview
    [PreserveSig]
    void ClearView(ID3D11View pView, [In][MarshalUsing(ConstantElementCount = 4)] float[] Color, nint /* optional RECT* */ pRect, uint NumRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardview1
    [PreserveSig]
    void DiscardView1(ID3D11View pResourceView, nint /* optional RECT* */ pRects, uint NumRects);
}
