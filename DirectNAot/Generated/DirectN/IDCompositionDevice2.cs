namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevice2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("75f6468d-1b8e-447c-9bc6-75fea80b5b25")]
public partial interface IDCompositionDevice2
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-waitforcommitcompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WaitForCommitCompletion();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameStatistics(out DCOMPOSITION_FRAME_STATISTICS statistics);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVisual(out IDCompositionVisual2 visual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createsurfacefactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurfaceFactory(nint renderingDevice, out IDCompositionSurfaceFactory surfaceFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, out IDCompositionSurface surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createvirtualsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, out IDCompositionVirtualSurface virtualSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtranslatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTranslateTransform(out IDCompositionTranslateTransform translateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createscaletransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateScaleTransform(out IDCompositionScaleTransform scaleTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createrotatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRotateTransform(out IDCompositionRotateTransform rotateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createskewtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSkewTransform(out IDCompositionSkewTransform skewTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-creatematrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateMatrixTransform(out IDCompositionMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtransformgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTransformGroup(in IDCompositionTransform transforms, uint elements, out IDCompositionTransform transformGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtranslatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTranslateTransform3D(out IDCompositionTranslateTransform3D translateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createscaletransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateScaleTransform3D(out IDCompositionScaleTransform3D scaleTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createrotatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRotateTransform3D(out IDCompositionRotateTransform3D rotateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-creatematrixtransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateMatrixTransform3D(out IDCompositionMatrixTransform3D matrixTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtransform3dgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTransform3DGroup(in IDCompositionTransform3D transforms3D, uint elements, out IDCompositionTransform3D transform3DGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createeffectgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateEffectGroup(out IDCompositionEffectGroup effectGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createrectangleclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRectangleClip(out IDCompositionRectangleClip clip);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateAnimation(out IDCompositionAnimation animation);
}
