#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidoutputdevices
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5702cd2-9b79-11d3-b654-00c04f79498e")]
public partial interface IMSVidOutputDevices : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidoutputdevices-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int lCount);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidoutputdevices-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT pD);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidoutputdevices-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT v, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidOutputDevice>))] out IMSVidOutputDevice pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidoutputdevices-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidOutputDevice>))] IMSVidOutputDevice pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidoutputdevices-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT v);
}
