#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsviddevice
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1c15d47c-911d-11d2-b632-00c04f79498e")]
public partial interface IMSVidDevice : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get_status
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Status(out int Status);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-put_power
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Power(VARIANT_BOOL Power);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get_power
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Power(out VARIANT_BOOL Power);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get_category
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Category(out BSTR Guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get_classid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ClassID(out BSTR Clsid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get__category
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__Category(out Guid Guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-get__classid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__ClassID(out Guid Clsid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice-isequaldevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqualDevice(IMSVidDevice Device, out VARIANT_BOOL IsEqual);
}
