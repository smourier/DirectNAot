namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11devicecontext1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1")]
public partial interface ID3D11DeviceContext1 : ID3D11DeviceContext
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-copysubresourceregion1
    [PreserveSig]
    public void CopySubresourceRegion1(ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource pSrcResource, uint SrcSubresource, nint/* nint */ pSrcBox, uint CopyFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-updatesubresource1
    [PreserveSig]
    public void UpdateSubresource1(ID3D11Resource pDstResource, uint DstSubresource, nint/* nint */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardresource
    [PreserveSig]
    public void DiscardResource(ID3D11Resource pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardview
    [PreserveSig]
    public void DiscardView(ID3D11View pResourceView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-vssetconstantbuffers1
    [PreserveSig]
    public void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-hssetconstantbuffers1
    [PreserveSig]
    public void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-dssetconstantbuffers1
    [PreserveSig]
    public void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-gssetconstantbuffers1
    [PreserveSig]
    public void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-pssetconstantbuffers1
    [PreserveSig]
    public void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-cssetconstantbuffers1
    [PreserveSig]
    public void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-vsgetconstantbuffers1
    [PreserveSig]
    public void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-hsgetconstantbuffers1
    [PreserveSig]
    public void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-dsgetconstantbuffers1
    [PreserveSig]
    public void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-gsgetconstantbuffers1
    [PreserveSig]
    public void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-psgetconstantbuffers1
    [PreserveSig]
    public void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-csgetconstantbuffers1
    [PreserveSig]
    public void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, nint/* nint */ ppConstantBuffers, nint/* nint */ pFirstConstant, nint/* nint */ pNumConstants);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-swapdevicecontextstate
    [PreserveSig]
    public void SwapDeviceContextState(ID3DDeviceContextState pState, nint/* nint */ ppPreviousState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-clearview
    [PreserveSig]
    public void ClearView(ID3D11View pView, in float Color, nint/* nint */ pRect, uint NumRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11devicecontext1-discardview1
    [PreserveSig]
    public void DiscardView1(ID3D11View pResourceView, nint/* nint */ pRects, uint NumRects);
}
