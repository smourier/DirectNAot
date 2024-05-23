#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondesktopdevice
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("5f4633fe-1e08-4cb8-8c75-ce24333f5602")]
public partial interface IDCompositionDesktopDevice : IDCompositionDevice2
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondesktopdevice-createtargetforhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTargetForHwnd(HWND hwnd, [MarshalAs(UnmanagedType.U4)] bool topmost, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTarget>))] out IDCompositionTarget target);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondesktopdevice-createsurfacefromhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurfaceFromHandle(HANDLE handle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondesktopdevice-createsurfacefromhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurfaceFromHwnd(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint surface);
}
