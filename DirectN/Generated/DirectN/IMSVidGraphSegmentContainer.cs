#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidgraphsegmentcontainer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3dd2903d-e0aa-11d2-b63a-00c04f79498e")]
public partial interface IMSVidGraphSegmentContainer
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgraphsegmentcontainer-get_graph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Graph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] out IGraphBuilder ppGraph);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Input([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegment>))] out IMSVidGraphSegment ppInput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Outputs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMSVidGraphSegment>))] out IEnumMSVidGraphSegment ppOutputs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoRenderer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegment>))] out IMSVidGraphSegment ppVR);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioRenderer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegment>))] out IMSVidGraphSegment ppAR);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Features([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMSVidGraphSegment>))] out IEnumMSVidGraphSegment ppFeatures);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Composites([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMSVidGraphSegment>))] out IEnumMSVidGraphSegment ppComposites);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ParentContainer(out nint ppContainer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Decompose([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegment?>))] IMSVidGraphSegment? pSegment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsWindowless();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFocus();
}
