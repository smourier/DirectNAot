#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3e68d4bd-7135-4d10-8018-9fb6d9f33fa1")]
public partial interface IInitializeWithWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HWND hwnd);
}
