#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface ISpThreadTask
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitThread(nint pvTaskData, HWND hwnd);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ThreadProc(nint pvTaskData, HANDLE hExitThreadEvent, HANDLE hNotifyEvent, HWND hwndWorker, in int pfContinueProcessing);
    
    [PreserveSig]
    LRESULT WindowMessage(nint pvTaskData, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
}
