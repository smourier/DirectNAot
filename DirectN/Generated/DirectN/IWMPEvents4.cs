#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpevents4
[GeneratedComInterface, Guid("26dabcfa-306b-404d-9a6f-630a8405048d")]
public partial interface IWMPEvents4 : IWMPEvents3
{
    [PreserveSig]
    void DeviceEstimation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice, HRESULT hrResult, long qwEstimatedUsedSpace, long qwEstimatedSpace);
}
