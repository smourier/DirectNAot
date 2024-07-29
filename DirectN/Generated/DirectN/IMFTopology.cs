#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftopology
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("83cf873a-f6da-4bc8-823f-bacfd55dc433")]
public partial interface IMFTopology : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-gettopologyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTopologyID(out ulong pID);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-addnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddNode(IMFTopologyNode pNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-removenode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveNode(IMFTopologyNode pNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-getnodecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNodeCount(out ushort pwNodes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-getnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNode(ushort wIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopologyNode>))] out IMFTopologyNode ppNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-clonefrom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloneFrom(IMFTopology pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-getnodebyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNodeByID(ulong qwTopoNodeID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopologyNode>))] out IMFTopologyNode ppNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-getsourcenodecollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceNodeCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] out IMFCollection ppCollection);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopology-getoutputnodecollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputNodeCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] out IMFCollection ppCollection);
}
