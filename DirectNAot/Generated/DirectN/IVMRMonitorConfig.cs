#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrmonitorconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9cf0b1b6-fbaa-4b7f-88cf-cf1f130a0dce")]
public partial interface IVMRMonitorConfig
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmonitorconfig-setmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMonitor(in VMRGUID pGUID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmonitorconfig-getmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitor(out VMRGUID pGUID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmonitorconfig-setdefaultmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultMonitor(in VMRGUID pGUID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmonitorconfig-getdefaultmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultMonitor(out VMRGUID pGUID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmonitorconfig-getavailablemonitors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableMonitors([MarshalUsing(CountElementName = nameof(dwMaxInfoArraySize))] out VMRMONITORINFO[] pInfo, uint dwMaxInfoArraySize, out uint pdwNumDevices);
}
