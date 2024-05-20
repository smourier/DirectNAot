#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f90ad9d0-b854-4b68-9cc1-b2cc96119d85")]
public partial interface ISIInbandEPG
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartSIEPGScan();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopSIEPGScan();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSIEPGScanRunning([MarshalAs(UnmanagedType.U4)] out bool bRunning);
}
