#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftopologynode
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("83cf873a-f6da-4bc8-823f-bacfd55dc430")]
public partial interface IMFTopologyNode : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-setobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObject(nint pObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getnodetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNodeType(out MF_TOPOLOGY_TYPE pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-gettoponodeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTopoNodeID(out ulong pID);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-settoponodeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopoNodeID(ulong ullTopoID);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getinputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputCount(out uint pcInputs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getoutputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCount(out uint pcOutputs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-connectoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectOutput(uint dwOutputIndex, IMFTopologyNode pDownstreamNode, uint dwInputIndexOnDownstreamNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-disconnectoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisconnectOutput(uint dwOutputIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInput(uint dwInputIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopologyNode>))] out IMFTopologyNode ppUpstreamNode, out uint pdwOutputIndexOnUpstreamNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutput(uint dwOutputIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopologyNode>))] out IMFTopologyNode ppDownstreamNode, out uint pdwInputIndexOnDownstreamNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-setoutputpreftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputPrefType(uint dwOutputIndex, IMFMediaType pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getoutputpreftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputPrefType(uint dwOutputIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-setinputpreftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputPrefType(uint dwInputIndex, IMFMediaType pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-getinputpreftype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputPrefType(uint dwInputIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynode-clonefrom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloneFrom(IMFTopologyNode pNode);
}
