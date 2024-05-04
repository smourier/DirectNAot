#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/nn-dxcore_interface-idxcoreadapterfactory
[GeneratedComInterface, Guid("78ee5945-c36e-4b13-a669-005dd11c0f06")]
public partial interface IDXCoreAdapterFactory
{
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-createadapterlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAdapterList(uint numAttributes, [MarshalUsing(CountElementName = nameof(numAttributes))] in Guid[] filterAttributes, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvAdapterList);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-getadapterbyluid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapterByLuid(in LUID adapterLUID, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-isnotificationtypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsNotificationTypeSupported(DXCoreNotificationType notificationType);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-registereventnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterEventNotification(nint dxCoreObject, DXCoreNotificationType notificationType, PFN_DXCORE_NOTIFICATION_CALLBACK callbackFunction, nint /* optional void* */ callbackContext, out uint eventCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-unregistereventnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterEventNotification(uint eventCookie);
}
