#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-istreambuilder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868bf-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IStreamBuilder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-istreambuilder-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render(IPin ppinOut, IGraphBuilder pGraph);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-istreambuilder-backout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Backout(IPin ppinOut, IGraphBuilder pGraph);
}
