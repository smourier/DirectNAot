#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-ideferredcommand
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b8-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IDeferredCommand
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ideferredcommand-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ideferredcommand-confidence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Confidence(out int pConfidence);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ideferredcommand-postpone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Postpone(double newtime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ideferredcommand-gethresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHResult(out HRESULT phrResult);
}
