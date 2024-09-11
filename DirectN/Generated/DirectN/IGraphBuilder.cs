#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-igraphbuilder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868a9-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IGraphBuilder : IFilterGraph
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin ppinOut, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin ppinIn);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin ppinOut);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-renderfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderFile(PWSTR lpcwstrFile, PWSTR lpcwstrPlayList);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-addsourcefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSourceFilter(PWSTR lpcwstrFileName, PWSTR lpcwstrFilterName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] out IBaseFilter ppFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-setlogfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLogFile(nuint hFile);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-abort
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Abort();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphbuilder-shouldoperationcontinue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShouldOperationContinue();
}
