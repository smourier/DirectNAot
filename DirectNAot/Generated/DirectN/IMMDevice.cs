namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-immdevice
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d666063f-1587-4e43-81f1-b948e807363f")]
public partial interface IMMDevice
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdevice-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(in Guid iid, CLSCTX dwClsCtx, nint /* optional PROPVARIANT */ pActivationParams, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppInterface);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdevice-openpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenPropertyStore(STGM stgmAccess, out IPropertyStore ppProperties);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdevice-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out PWSTR ppstrId);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdevice-getstate
    [PreserveSig]
    DEVICE_STATE GetState(out uint pdwState);
}
