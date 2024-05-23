#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2streammap
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("667c7745-85b1-4c55-ae55-4e25056159fc")]
public partial interface ISBE2StreamMap
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2streammap-mapstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapStream(uint Stream);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2streammap-unmapstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnmapStream(uint Stream);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2streammap-enummappedstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMappedStreams([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISBE2EnumStream>))] out ISBE2EnumStream ppStreams);
}
