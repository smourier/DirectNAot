#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidvideorendererdevices
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5702cd3-9b79-11d3-b654-00c04f79498e")]
public partial interface IMSVidVideoRendererDevices : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererdevices-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int lCount);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererdevices-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT pD);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererdevices-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT v, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidVideoRenderer>))] out IMSVidVideoRenderer pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererdevices-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(IMSVidVideoRenderer pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererdevices-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT v);
}
