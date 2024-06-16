#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-icapturegraphbuilder2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("93e5a4e0-2d50-11d2-abfa-00a0c9c6e38d")]
public partial interface ICaptureGraphBuilder2
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-setfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFiltergraph(IGraphBuilder pfg);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-getfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFiltergraph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] out IGraphBuilder ppfg);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-setoutputfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFileName(in Guid pType, PWSTR lpstrFile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] out IBaseFilter ppf, nint /* optional IFileSinkFilter* */ ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-findinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindInterface(nint /* optional Guid* */ pCategory, nint /* optional Guid* */ pType, IBaseFilter pf, in Guid riid, out nint ppint);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-renderstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderStream(nint /* optional Guid* */ pCategory, in Guid pType, nint pSource, IBaseFilter pfCompressor, IBaseFilter pfRenderer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-controlstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ControlStream(in Guid pCategory, in Guid pType, IBaseFilter pFilter, nint /* optional long* */ pstart, nint /* optional long* */ pstop, ushort wStartCookie, ushort wStopCookie);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-alloccapfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocCapFile(PWSTR lpstr, ulong dwlSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-copycapturefile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyCaptureFile(PWSTR lpwstrOld, PWSTR lpwstrNew, int fAllowEscAbort, IAMCopyCaptureFileProgress pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icapturegraphbuilder2-findpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindPin(nint pSource, PIN_DIRECTION pindir, nint /* optional Guid* */ pCategory, nint /* optional Guid* */ pType, BOOL fUnconnected, int num, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] out IPin ppPin);
}
