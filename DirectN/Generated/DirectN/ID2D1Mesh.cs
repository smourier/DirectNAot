#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1mesh
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906c2-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1Mesh : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1mesh-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TessellationSink>))] out ID2D1TessellationSink tessellationSink);
}
