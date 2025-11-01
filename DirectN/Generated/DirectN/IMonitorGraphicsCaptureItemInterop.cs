#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("33274d14-a076-4048-8416-747e9b04db7b")]
public partial interface IMonitorGraphicsCaptureItemInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitor(ref HMONITOR monitor);
}
