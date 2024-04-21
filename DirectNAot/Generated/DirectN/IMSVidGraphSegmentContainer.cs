namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidgraphsegmentcontainer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3dd2903d-e0aa-11d2-b63a-00c04f79498e")]
public partial interface IMSVidGraphSegmentContainer
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgraphsegmentcontainer-get_graph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Graph(out IGraphBuilder ppGraph);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Input(out IMSVidGraphSegment ppInput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Outputs(out IEnumMSVidGraphSegment ppOutputs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoRenderer(out IMSVidGraphSegment ppVR);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioRenderer(out IMSVidGraphSegment ppAR);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Features(out IEnumMSVidGraphSegment ppFeatures);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Composites(out IEnumMSVidGraphSegment ppComposites);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ParentContainer(out nint ppContainer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Decompose(IMSVidGraphSegment? pSegment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsWindowless();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFocus();
}
