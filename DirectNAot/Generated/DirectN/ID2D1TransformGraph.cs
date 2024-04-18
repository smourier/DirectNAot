namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformgraph
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("13d29038-c3e6-4034-9081-13b53a417992")]
public partial interface ID2D1TransformGraph
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-getinputcount
    [PreserveSig]
    public uint GetInputCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setsingletransformnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSingleTransformNode(ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-addnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddNode(ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-removenode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveNode(ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setoutputnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOutputNode(ID2D1TransformNode node);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connectnode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ConnectNode(ID2D1TransformNode fromNode, ID2D1TransformNode toNode, uint toNodeInputIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-connecttoeffectinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ConnectToEffectInput(uint toEffectInputIndex, ID2D1TransformNode node, uint toNodeInputIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-clear
    [PreserveSig]
    public void Clear();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformgraph-setpassthroughgraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPassthroughGraph(uint effectInputIndex);
}
