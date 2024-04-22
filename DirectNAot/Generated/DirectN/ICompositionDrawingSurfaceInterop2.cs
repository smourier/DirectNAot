namespace DirectN;

[GeneratedComInterface, Guid("41e64aae-98c0-4239-8e95-a330dd6aa18b")]
public partial interface ICompositionDrawingSurfaceInterop2 : ICompositionDrawingSurfaceInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop2-copysurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopySurface(nint destinationResource, int destinationOffsetX, int destinationOffsetY, nint /* optional FoundationRECT */ sourceRectangle);
}
