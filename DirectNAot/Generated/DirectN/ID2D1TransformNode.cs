namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transformnode
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b2efe1e7-729f-4102-949f-505fa21bf666")]
public partial interface ID2D1TransformNode
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transformnode-getinputcount
    [PreserveSig]
    public uint GetInputCount();
}
