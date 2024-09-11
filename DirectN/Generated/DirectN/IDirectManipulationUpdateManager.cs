#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationupdatemanager
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b0ae62fd-be34-46e7-9caa-d361facbb9cc")]
public partial interface IDirectManipulationUpdateManager
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationupdatemanager-registerwaithandlecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterWaitHandleCallback(HANDLE handle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectManipulationUpdateHandler>))] IDirectManipulationUpdateHandler eventHandler, out uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationupdatemanager-unregisterwaithandlecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterWaitHandleCallback(uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationupdatemanager-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectManipulationFrameInfoProvider?>))] IDirectManipulationFrameInfoProvider? frameInfo);
}
