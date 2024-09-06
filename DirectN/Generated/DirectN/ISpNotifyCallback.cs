#nullable enable
namespace DirectN;

public partial struct ISpNotifyCallback
{
    public static readonly ISpNotifyCallback Null = new();
    
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT NotifyCallback(WPARAM wParam, LPARAM lParam) =>
        ((delegate* unmanaged<ISpNotifyCallback*,WPARAM,LPARAM, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ISpNotifyCallback*)VTablePtr, wParam, lParam);
}
