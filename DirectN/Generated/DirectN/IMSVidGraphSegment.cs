#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("238dec54-adeb-4005-a349-f772b9afebc4")]
public partial interface IMSVidGraphSegment : IPersist
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Init(out nint pInit);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Init(nint pInit);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumFilters([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumFilters>))] out IEnumFilters pNewEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Container([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegmentContainer>))] out IMSVidGraphSegmentContainer ppCtl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Container(IMSVidGraphSegmentContainer pCtl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out MSVidSegmentType pType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Category(out Guid pGuid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Build();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostBuild();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreRun();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostRun();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreStop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostStop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEventNotify(int lEventCode, nint lEventParm1, nint lEventParm2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Decompose();
}
