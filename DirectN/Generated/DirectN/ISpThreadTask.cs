#nullable enable
namespace DirectN;

public partial struct ISpThreadTask
{
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT InitThread(nint pvTaskData, HWND hwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpThreadTask*,nint,HWND, HRESULT>)(((void**)VTablePtr)[0]))((ISpThreadTask*)VTablePtr, pvTaskData, hwnd);
    }
    
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT ThreadProc(nint pvTaskData, HANDLE hExitThreadEvent, HANDLE hNotifyEvent, HWND hwndWorker, in int pfContinueProcessing)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpThreadTask*,nint,HANDLE,HANDLE,HWND,int, HRESULT>)(((void**)VTablePtr)[1]))((ISpThreadTask*)VTablePtr, pvTaskData, hExitThreadEvent, hNotifyEvent, hwndWorker, pfContinueProcessing);
    }
    
    public unsafe LRESULT WindowMessage(nint pvTaskData, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpThreadTask*,nint,HWND,uint,WPARAM,LPARAM, LRESULT>)(((void**)VTablePtr)[2]))((ISpThreadTask*)VTablePtr, pvTaskData, hWnd, Msg, wParam, lParam);
    }
}
