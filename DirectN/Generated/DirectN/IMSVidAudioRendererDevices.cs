#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidaudiorendererdevices
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5702cd4-9b79-11d3-b654-00c04f79498e")]
public partial interface IMSVidAudioRendererDevices : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererdevices-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int lCount);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererdevices-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT pD);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererdevices-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT v, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidAudioRenderer>))] out IMSVidAudioRenderer pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererdevices-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(IMSVidAudioRenderer pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidaudiorendererdevices-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT v);
}
