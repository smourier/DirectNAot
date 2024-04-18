namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevice
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c37ea93a-e7aa-450d-b16f-9746cb0407f3")]
public partial interface IDCompositionDevice
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-waitforcommitcompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WaitForCommitCompletion();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameStatistics(out DCOMPOSITION_FRAME_STATISTICS statistics);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtargetforhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTargetForHwnd(HWND hwnd, [MarshalAs(UnmanagedType.U4)] bool topmost, out IDCompositionTarget target);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVisual(out IDCompositionVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, out IDCompositionSurface surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createvirtualsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, out IDCompositionVirtualSurface virtualSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createsurfacefromhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurfaceFromHandle(HANDLE handle, out nint surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createsurfacefromhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurfaceFromHwnd(HWND hwnd, out nint surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtranslatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTranslateTransform(out IDCompositionTranslateTransform translateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createscaletransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateScaleTransform(out IDCompositionScaleTransform scaleTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createrotatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRotateTransform(out IDCompositionRotateTransform rotateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createskewtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSkewTransform(out IDCompositionSkewTransform skewTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-creatematrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateMatrixTransform(out IDCompositionMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtransformgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTransformGroup(in IDCompositionTransform transforms, uint elements, out IDCompositionTransform transformGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtranslatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTranslateTransform3D(out IDCompositionTranslateTransform3D translateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createscaletransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateScaleTransform3D(out IDCompositionScaleTransform3D scaleTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createrotatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRotateTransform3D(out IDCompositionRotateTransform3D rotateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-creatematrixtransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateMatrixTransform3D(out IDCompositionMatrixTransform3D matrixTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtransform3dgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTransform3DGroup(in IDCompositionTransform3D transforms3D, uint elements, out IDCompositionTransform3D transform3DGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createeffectgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateEffectGroup(out IDCompositionEffectGroup effectGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createrectangleclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRectangleClip(out IDCompositionRectangleClip clip);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateAnimation(out IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-checkdevicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckDeviceState([MarshalAs(UnmanagedType.U4)] out bool pfValid);
}
