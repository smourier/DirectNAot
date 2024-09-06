#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("29e691fa-4567-4dca-b319-d0f207eb6807")]
public partial interface ICompositorDesktopInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDesktopWindowTarget(HWND hwndTarget, BOOL isTopmost, out nint /* object */ result);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnsureOnThread(uint threadId);
}
