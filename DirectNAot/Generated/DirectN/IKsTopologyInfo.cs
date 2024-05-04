#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vidcap/nn-vidcap-ikstopologyinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("720d4ac0-7533-11d0-a5d6-28db04c10000")]
public partial interface IKsTopologyInfo
{
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_numcategories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumCategories(out uint pdwNumCategories);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_category
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Category(uint dwIndex, out Guid pCategory);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_numconnections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumConnections(out uint pdwNumConnections);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_connectioninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ConnectionInfo(uint dwIndex, out KSTOPOLOGY_CONNECTION pConnectionInfo);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_nodename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NodeName(uint dwNodeId, out PWSTR? pwchNodeName, uint dwBufSize, out uint pdwNameLen);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_numnodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumNodes(out uint pdwNumNodes);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-get_nodetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NodeType(uint dwNodeId, out Guid pNodeType);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ikstopologyinfo-createnodeinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNodeInstance(uint dwNodeId, in Guid iid, out nint ppvObject);
}
