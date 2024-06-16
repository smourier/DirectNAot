#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/nn-dxgidebug-idxgidebug1
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("c5a05f0c-16f2-4adf-9f4d-a8c4d58ac550")]
public partial interface IDXGIDebug1 : IDXGIDebug
{
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgidebug1-enableleaktrackingforthread
    [PreserveSig]
    void EnableLeakTrackingForThread();
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgidebug1-disableleaktrackingforthread
    [PreserveSig]
    void DisableLeakTrackingForThread();
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgidebug1-isleaktrackingenabledforthread
    [PreserveSig]
    BOOL IsLeakTrackingEnabledForThread();
}
