#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-iaudiosystemeffectspropertystore
[GeneratedComInterface, Guid("302ae7f9-d7e0-43e4-971b-1f8293613d2a")]
public partial interface IAudioSystemEffectsPropertyStore
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-opendefaultpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenDefaultPropertyStore(uint stgmAccess, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore propStore);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-openuserpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenUserPropertyStore(uint stgmAccess, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore propStore);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-openvolatilepropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenVolatilePropertyStore(uint stgmAccess, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore propStore);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-resetuserpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetUserPropertyStore();
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-resetvolatilepropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetVolatilePropertyStore();
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-registerpropertychangenotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterPropertyChangeNotification([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioSystemEffectsPropertyChangeNotificationClient>))] IAudioSystemEffectsPropertyChangeNotificationClient callback);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertystore-unregisterpropertychangenotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterPropertyChangeNotification([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioSystemEffectsPropertyChangeNotificationClient>))] IAudioSystemEffectsPropertyChangeNotificationClient callback);
}
