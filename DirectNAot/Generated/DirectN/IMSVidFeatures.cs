#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidfeatures
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c5702cd5-9b79-11d3-b654-00c04f79498e")]
public partial interface IMSVidFeatures : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfeatures-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int lCount);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfeatures-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out IEnumVARIANT pD);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfeatures-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT v, out IMSVidFeature pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfeatures-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(IMSVidFeature pDB);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidfeatures-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT v);
}
