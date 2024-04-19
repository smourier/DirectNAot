namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidinputdevices
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5702cd1-9b79-11d3-b654-00c04f79498e")]
public partial interface IMSVidInputDevices : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevices-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int lCount);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevices-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out IEnumVARIANT pD);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevices-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT v, out IMSVidInputDevice pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevices-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(IMSVidInputDevice pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevices-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT v);
}
