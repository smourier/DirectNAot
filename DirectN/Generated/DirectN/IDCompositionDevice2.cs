﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevice2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("75f6468d-1b8e-447c-9bc6-75fea80b5b25")]
public partial interface IDCompositionDevice2
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-waitforcommitcompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForCommitCompletion();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatistics(out DCOMPOSITION_FRAME_STATISTICS statistics);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVisual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionVisual2>))] out IDCompositionVisual2 visual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createsurfacefactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurfaceFactory(nint renderingDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionSurfaceFactory>))] out IDCompositionSurfaceFactory surfaceFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionSurface>))] out IDCompositionSurface surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createvirtualsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionVirtualSurface>))] out IDCompositionVirtualSurface virtualSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtranslatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTranslateTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTranslateTransform>))] out IDCompositionTranslateTransform translateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createscaletransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateScaleTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionScaleTransform>))] out IDCompositionScaleTransform scaleTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createrotatetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRotateTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionRotateTransform>))] out IDCompositionRotateTransform rotateTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createskewtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSkewTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionSkewTransform>))] out IDCompositionSkewTransform skewTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-creatematrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMatrixTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionMatrixTransform>))] out IDCompositionMatrixTransform matrixTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtransformgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransformGroup([In][MarshalUsing(CountElementName = nameof(elements))] IDCompositionTransform[] transforms, uint elements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTransform>))] out IDCompositionTransform transformGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtranslatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTranslateTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTranslateTransform3D>))] out IDCompositionTranslateTransform3D translateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createscaletransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateScaleTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionScaleTransform3D>))] out IDCompositionScaleTransform3D scaleTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createrotatetransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRotateTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionRotateTransform3D>))] out IDCompositionRotateTransform3D rotateTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-creatematrixtransform3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMatrixTransform3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionMatrixTransform3D>))] out IDCompositionMatrixTransform3D matrixTransform3D);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createtransform3dgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransform3DGroup([In][MarshalUsing(CountElementName = nameof(elements))] IDCompositionTransform3D[] transforms3D, uint elements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTransform3D>))] out IDCompositionTransform3D transform3DGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createeffectgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEffectGroup([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionEffectGroup>))] out IDCompositionEffectGroup effectGroup);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createrectangleclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRectangleClip([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionRectangleClip>))] out IDCompositionRectangleClip clip);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice2-createanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAnimation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] out IDCompositionAnimation animation);
}
