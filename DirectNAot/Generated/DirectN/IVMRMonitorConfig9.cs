namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrmonitorconfig9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("46c2e457-8ba0-4eef-b80b-0680f0978749")]
public partial interface IVMRMonitorConfig9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmonitorconfig9-setmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMonitor(uint uDev);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmonitorconfig9-getmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitor(out uint puDev);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmonitorconfig9-setdefaultmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultMonitor(uint uDev);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmonitorconfig9-getdefaultmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultMonitor(out uint puDev);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmonitorconfig9-getavailablemonitors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableMonitors(out VMR9MonitorInfo pInfo, uint dwMaxInfoArraySize, out uint pdwNumDevices);
}
