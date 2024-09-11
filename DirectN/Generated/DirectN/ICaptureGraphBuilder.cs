#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-icapturegraphbuilder
[GeneratedComInterface, Guid("bf87b6e0-8c27-11d0-b3f0-00aa003761c5")]
public partial interface ICaptureGraphBuilder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-setfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFiltergraph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pfg);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-getfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFiltergraph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] out IGraphBuilder ppfg);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-setoutputfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFileName(in Guid pType, PWSTR lpstrFile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] out IBaseFilter ppf, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileSinkFilter>))] out IFileSinkFilter ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-findinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindInterface(nint /* optional Guid* */ pCategory, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pf, in Guid riid, out nint ppint);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-renderstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderStream(nint /* optional Guid* */ pCategory, nint pSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pfCompressor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pfRenderer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-controlstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ControlStream(nint /* optional Guid* */ pCategory, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pFilter, in long pstart, in long pstop, ushort wStartCookie, ushort wStopCookie);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-alloccapfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocCapFile(PWSTR lpstr, ulong dwlSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder-copycapturefile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyCaptureFile(PWSTR lpwstrOld, PWSTR lpwstrNew, int fAllowEscAbort, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAMCopyCaptureFileProgress>))] IAMCopyCaptureFileProgress pCallback);
}
