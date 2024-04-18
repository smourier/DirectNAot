﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgioutputduplication
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("191cfac3-a341-470d-b26e-a864f428319c")]
public partial interface IDXGIOutputDuplication : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-getdesc
    [PreserveSig]
    public void GetDesc(out DXGI_OUTDUPL_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-acquirenextframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AcquireNextFrame(uint TimeoutInMilliseconds, out DXGI_OUTDUPL_FRAME_INFO pFrameInfo, out IDXGIResource ppDesktopResource);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-getframedirtyrects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameDirtyRects(uint DirtyRectsBufferSize, out FoundationRECT pDirtyRectsBuffer, out uint pDirtyRectsBufferSizeRequired);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-getframemoverects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameMoveRects(uint MoveRectsBufferSize, out DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer, out uint pMoveRectsBufferSizeRequired);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-getframepointershape
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFramePointerShape(uint PointerShapeBufferSize, nint pPointerShapeBuffer, out uint pPointerShapeBufferSizeRequired, out DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-mapdesktopsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MapDesktopSurface(out DXGI_MAPPED_RECT pLockedRect);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-unmapdesktopsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnMapDesktopSurface();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutputduplication-releaseframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReleaseFrame();
}
