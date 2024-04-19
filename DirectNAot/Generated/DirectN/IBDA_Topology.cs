namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_topology
[GeneratedComInterface, Guid("79b56888-7fea-4690-b45d-38fd3c7849be")]
public partial interface IBDA_Topology
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-getnodetypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNodeTypes(ref uint pulcNodeTypes, uint ulcNodeTypesMax, ref uint rgulNodeTypes);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-getnodedescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNodeDescriptors(ref uint ulcNodeDescriptors, uint ulcNodeDescriptorsMax, ref BDANODE_DESCRIPTOR rgNodeDescriptors);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-getnodeinterfaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNodeInterfaces(uint ulNodeType, ref uint pulcInterfaces, uint ulcInterfacesMax, ref Guid rgguidInterfaces);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-getpintypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPinTypes(ref uint pulcPinTypes, uint ulcPinTypesMax, ref uint rgulPinTypes);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-gettemplateconnections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTemplateConnections(ref uint pulcConnections, uint ulcConnectionsMax, ref BDA_TEMPLATE_CONNECTION rgConnections);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-createpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePin(uint ulPinType, ref uint pulPinId);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-deletepin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeletePin(uint ulPinId);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-setmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaType(uint ulPinId, in AM_MEDIA_TYPE pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-setmedium
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMedium(uint ulPinId, in REGPINMEDIUM pMedium);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-createtopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTopology(uint ulInputPinId, uint ulOutputPinId);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_topology-getcontrolnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlNode(uint ulInputPinId, uint ulOutputPinId, uint ulNodeType, ref nint ppControlNode);
}
