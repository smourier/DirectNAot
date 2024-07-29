#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1effectimpl
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a248fd3f-3e6c-4e63-9f03-7f68ecc91db9")]
public partial interface ID2D1EffectImpl
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectimpl-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ID2D1EffectContext effectContext, ID2D1TransformGraph transformGraph);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectimpl-prepareforrender
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrepareForRender(D2D1_CHANGE_TYPE changeType);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectimpl-setgraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGraph(ID2D1TransformGraph transformGraph);
}
