#nullable enable
namespace DirectN;

public partial struct ISpNotifyCallback
{
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT NotifyCallback(WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpNotifyCallback*,WPARAM,LPARAM, HRESULT>)(((void**)VTablePtr)[0]))((ISpNotifyCallback*)VTablePtr, wParam, lParam);
    }
}
