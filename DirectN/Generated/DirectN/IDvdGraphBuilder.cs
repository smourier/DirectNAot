#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdgraphbuilder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fcc152b6-f372-11d0-8e00-00c04fd7c08b")]
public partial interface IDvdGraphBuilder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdgraphbuilder-getfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFiltergraph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] out IGraphBuilder ppGB);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdgraphbuilder-getdvdinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDvdInterface(in Guid riid, out nint ppvIF);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdgraphbuilder-renderdvdvideovolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderDvdVideoVolume(PWSTR lpcwszPathName, uint dwFlags, out AM_DVD_RENDERSTATUS pStatus);
}
