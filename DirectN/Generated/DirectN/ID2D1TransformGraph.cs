#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformgraph
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("13d29038-c3e6-4034-9081-13b53a417992")]
public partial interface ID2D1TransformGraph
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-getinputcount
    [PreserveSig]
    uint GetInputCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setsingletransformnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSingleTransformNode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-addnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddNode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-removenode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveNode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setoutputnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputNode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connectnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectNode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode fromNode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode toNode, uint toNodeInputIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connecttoeffectinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectToEffectInput(uint toEffectInputIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformNode>))] ID2D1TransformNode node, uint toNodeInputIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-clear
    [PreserveSig]
    void Clear();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setpassthroughgraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPassthroughGraph(uint effectInputIndex);
}
