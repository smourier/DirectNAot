#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevice
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c37ea93a-e7aa-450d-b16f-9746cb0407f3")]
public partial interface IDCompositionDevice
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-waitforcommitcompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForCommitCompletion();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatistics(out DCOMPOSITION_FRAME_STATISTICS statistics);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtargetforhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTargetForHwnd(HWND hwnd, BOOL topmost, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTarget>))] out IDCompositionTarget target);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVisual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionVisual>))] out IDCompositionVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionSurface>))] out IDCompositionSurface surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createvirtualsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionVirtualSurface>))] out IDCompositionVirtualSurface virtualSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createsurfacefromhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurfaceFromHandle(HANDLE handle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createsurfacefromhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurfaceFromHwnd(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtranslatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTranslateTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTranslateTransform>))] out IDCompositionTranslateTransform translateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createscaletransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateScaleTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionScaleTransform>))] out IDCompositionScaleTransform scaleTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createrotatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRotateTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionRotateTransform>))] out IDCompositionRotateTransform rotateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createskewtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSkewTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionSkewTransform>))] out IDCompositionSkewTransform skewTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-creatematrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMatrixTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionMatrixTransform>))] out IDCompositionMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtransformgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransformGroup([In][MarshalUsing(CountElementName = nameof(elements))] IDCompositionTransform[] transforms, uint elements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTransform>))] out IDCompositionTransform transformGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtranslatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTranslateTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTranslateTransform3D>))] out IDCompositionTranslateTransform3D translateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createscaletransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateScaleTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionScaleTransform3D>))] out IDCompositionScaleTransform3D scaleTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createrotatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRotateTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionRotateTransform3D>))] out IDCompositionRotateTransform3D rotateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-creatematrixtransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMatrixTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionMatrixTransform3D>))] out IDCompositionMatrixTransform3D matrixTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createtransform3dgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransform3DGroup([In][MarshalUsing(CountElementName = nameof(elements))] IDCompositionTransform3D[] transforms3D, uint elements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTransform3D>))] out IDCompositionTransform3D transform3DGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createeffectgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEffectGroup([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionEffectGroup>))] out IDCompositionEffectGroup effectGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createrectangleclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRectangleClip([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionRectangleClip>))] out IDCompositionRectangleClip clip);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-createanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAnimation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] out IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice-checkdevicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceState(out BOOL pfValid);
}
