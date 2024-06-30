#nullable enable
namespace DirectN;

public partial struct ISpThreadTask
{
    public static readonly ISpThreadTask Null = new();
    
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT InitThread(nint pvTaskData, HWND hwnd) =>
        ((delegate* unmanaged<ISpThreadTask*,nint,HWND, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ISpThreadTask*)VTablePtr, pvTaskData, hwnd);
    
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT ThreadProc(nint pvTaskData, HANDLE hExitThreadEvent, HANDLE hNotifyEvent, HWND hwndWorker, in int pfContinueProcessing) =>
        ((delegate* unmanaged<ISpThreadTask*,nint,HANDLE,HANDLE,HWND,int, HRESULT>)(((void**)*((void**)VTablePtr))[1]))((ISpThreadTask*)VTablePtr, pvTaskData, hExitThreadEvent, hNotifyEvent, hwndWorker, pfContinueProcessing);
    
    public readonly unsafe LRESULT WindowMessage(nint pvTaskData, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam) =>
        ((delegate* unmanaged<ISpThreadTask*,nint,HWND,uint,WPARAM,LPARAM, LRESULT>)(((void**)*((void**)VTablePtr))[2]))((ISpThreadTask*)VTablePtr, pvTaskData, hWnd, Msg, wParam, lParam);
}
